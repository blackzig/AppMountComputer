using AppMountComputer.Banco;
using AppMountComputer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMountComputer.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaProcessador : ContentPage
    {
        public ConsultaProcessador()
        {
            InitializeComponent();

            Database database = new Database();
            var lista = database.Consultar();
            ListaProcessadores.ItemsSource = lista;

            lblCount.Text = lista.Count.ToString();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroProcessador());
        }

        public void GoMinhasPecas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasPecas());
        }

        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest =
           (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Processador processador = tapGest.
            CommandParameter as Processador;
            Navigation.PushAsync(new DetalhePeca(processador));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}