namespace unit1_codes
{
    public partial class Form1 : Form
    {
        private List<string> datosDinamicos;
        public Form1()
        {
            InitializeComponent();
            datosDinamicos = new List<string>();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            if (!string.IsNullOrWhiteSpace(dato))
            {
                datosDinamicos.Add(dato); // Agregar dato a la lista
                ActualizarLista();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un dato válido.");
            }
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if (datosDinamicos.Count > 0)
            {
                datosDinamicos.RemoveAt(datosDinamicos.Count - 1); // Eliminar el último dato
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar.");
            }
        }

        private void ActualizarLista()
        {
            listBoxDatos.Items.Clear();
            listBoxDatos.Items.AddRange(datosDinamicos.ToArray());
        }
    }
}
