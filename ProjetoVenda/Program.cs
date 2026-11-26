using ProjetoVenda.Controle;
using ProjetoVenda.model;
using ProjetoVenda.view;
using QuestPDF.Infrastructure;

namespace ProjetoVenda
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmCadastroFuncionario());
            Relatorio relatorio = new Relatorio();
            
            //var  documento = relatorio.GerarNota(items);
            //relatorio.SalvarPDF(documento);
           

            while (true)
            {
                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }
                using (frmPrincipal principal = new frmPrincipal())
                {
                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }

            }



        }
    }
}