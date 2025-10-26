using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace VerificadorParentesis
{
    public partial class Form1 : Form
    {
        private const string EJEMPLO = "(2+3)*(4+(5-1))";

        public Form1()
        {
            InitializeComponent();
            // Placeholder compatible: usa PlaceholderText si existe; si no, usa cue banner.
            SetPlaceholderCompat(txtExpresion, EJEMPLO);
            lblResultado.Text = "Resultado...";
            lblResultado.ForeColor = Color.DimGray;
        }

        // --- Placeholder compatible entre .NET Framework y .NET 6+ ---
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        private void SetPlaceholderCompat(TextBox tb, string text)
        {
            try
            {
                // Si el TextBox tiene propiedad PlaceholderText (WinForms .NET 6+)
                PropertyInfo? p = tb.GetType().GetProperty("PlaceholderText");
                if (p != null && p.CanWrite)
                {
                    p.SetValue(tb, text, null);
                    return;
                }
            }
            catch { /* ignorar y probar con cue banner */ }

            // Cue banner para .NET Framework clásico
            try { SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)1, text); }
            catch { /* si falla, no pasa nada */ }
        }

        // --- Lógica de UI ---
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text?.Trim() ?? string.Empty;
            if (expresion.Length == 0)
            {
                MostrarResultado("Ingrese una expresión para verificar.", Color.DarkGoldenrod);
                return;
            }

            // Caso neutral: no hay paréntesis en la expresión
            if (!expresion.Contains('(') && !expresion.Contains(')'))
            {
                MostrarResultado("La expresión no contiene paréntesis.", Color.DimGray);
                return;
            }

            bool balanceada = VerificarParentesis(expresion, out string detalle);
            MostrarResultado(detalle, balanceada ? Color.ForestGreen : Color.IndianRed);
        }

        private void btnEnunciado_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Ejercicio 3: Verificación de Paréntesis Balanceados");
            sb.AppendLine("Utilizando el concepto de pila, cree un programa que determine si los paréntesis de una expresión matemática están correctamente balanceados.");
            sb.AppendLine();
            sb.AppendLine("Problema a resolver:");
            sb.AppendLine("1) Leer una cadena que contenga paréntesis (ej.: \"(2+3)*(4+(5-1))\").");
            sb.AppendLine("2) Recorrer la cadena carácter por carácter.");
            sb.AppendLine("3) Cada vez que se encuentre un '(', apilarlo.");
            sb.AppendLine("4) Cada vez que se encuentre un ')', desapilar un elemento.");
            sb.AppendLine("5) Al finalizar, verificar si la pila está vacía (expresión balanceada) o no.");
            sb.AppendLine("6) Mostrar el mensaje correspondiente.");
            MessageBox.Show(sb.ToString(), "Enunciado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
            lblResultado.Text = "Resultado...";
            lblResultado.ForeColor = Color.DimGray;
            txtExpresion.Focus();
        }

        private void txtExpresion_TextChanged(object sender, EventArgs e)
        {
            // Limpia el resultado cuando el usuario cambia la entrada (feedback inmediato)
            if (!string.IsNullOrWhiteSpace(lblResultado.Text) && lblResultado.Text != "Resultado...")
            {
                lblResultado.Text = "Resultado...";
                lblResultado.ForeColor = Color.DimGray;
            }
        }

        // Asegura que Tab sea tratado como tecla de entrada para poder autocompletar
        private void txtExpresion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && string.IsNullOrWhiteSpace(txtExpresion.Text))
            {
                e.IsInputKey = true; // Permite que KeyDown reciba la tecla Tab
            }
        }

        // Tab autocompleta SOLO si el TextBox está vacío
        private void txtExpresion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && string.IsNullOrWhiteSpace(txtExpresion.Text))
            {
                txtExpresion.Text = EJEMPLO;
                txtExpresion.SelectionStart = txtExpresion.Text.Length;
                e.SuppressKeyPress = true; // Evita mover el foco
            }
        }

        // --- Lógica de verificación con pila ---
        private bool VerificarParentesis(string expresion, out string detalle)
        {
            Stack<int> pila = new Stack<int>(); // Índices de '('
            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];
                if (c == '(')
                {
                    pila.Push(i);
                }
                else if (c == ')')
                {
                    if (pila.Count == 0)
                    {
                        detalle = $"No balanceada: ')' sin pareja en la posición {i} (índice base 0).";
                        return false;
                    }
                    pila.Pop();
                }
            }

            if (pila.Count == 0)
            {
                detalle = "Balanceada: todos los paréntesis están correctamente emparejados.";
                return true;
            }
            else
            {
                int primeroSinCerrar = pila.Peek();
                detalle = $"No balanceada: '(' sin cerrar; por ejemplo, el primero sin pareja está en la posición {primeroSinCerrar} (índice base 0).";
                return false;
            }
        }

        private void MostrarResultado(string mensaje, Color color)
        {
            lblResultado.Text = mensaje;
            lblResultado.ForeColor = color;
        }
    }
}
