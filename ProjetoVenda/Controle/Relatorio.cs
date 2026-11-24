using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;


namespace ProjetoVenda.Controle
{
    internal class Relatorio
    {
        public Document GerarNota()
        {
            var documento = Document.Create(conteudo =>
            {
                conteudo.Page(pagina =>
            {
                pagina.Size(QuestPDF.Helpers.PageSizes.A6);
                pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                pagina.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);
                pagina.DefaultTextStyle(fonte => fonte.FontSize(10));
                pagina.Header().Column(coluna =>
                {
                    coluna.Item().AlignCenter().Text("CUPOM DE VENDA").FontSize(18).Bold();
                    coluna.Item().LineHorizontal(2);
                    coluna.Item().AlignCenter().Text("Laranja Secreta");
                    coluna.Item().AlignCenter().Text("R.Queda de um Artista N°6060").FontSize(5);
                });
                pagina.Content();
                pagina.Footer().Column(coluna =>
                {
                    coluna.Item().LineHorizontal(0.5f);
                    coluna.Item().AlignCenter().Text("23/11/2026").FontSize(10);
                    coluna.Item().AlignCenter().Text("Obrigado pela Preferencia");
                    coluna.Item().AlignCenter().Text("todos os produtos e funcionarios tem um pasado duvidoso").FontSize(0.5f);


                });
            });
            });
            return documento;
    
    }
    public void SalvarPDF()
        {
            var Dialogo = new SaveFileDialog
            {
                Title = "Salvar Documento",
                FileName = "Little-Nota",
                Filter = "(PDF)|*.pdf"
            };
            if(Dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = GerarNota();
                documento.GeneratePdf(Dialogo.FileName);
            }
            
            
        }
    }

}
