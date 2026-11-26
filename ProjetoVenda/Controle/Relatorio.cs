using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Text;
using ProjetoVenda.controller;
using ProjetoVenda.model;
using QuestPDF.Fluent;


namespace ProjetoVenda.Controle
{
    internal class Relatorio
    {
        public Document GerarNota(List<Item> items)
        {
            var documento = Document.Create(conteudo =>

            {
                conteudo.Page(pagina =>
            {
                string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                pagina.Size(QuestPDF.Helpers.PageSizes.A5);
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
                
                pagina.Content().Column(coluna =>
                {
                    coluna.Item().Row(linha =>
                    {
                        linha.RelativeItem().Text("Item").FontSize(8);
                        linha.RelativeItem(3).Text("Nome Do Item").FontSize(8);
                        linha.RelativeItem(3).Text("Marca").FontSize(8);
                        linha.RelativeItem().Text("QTD").FontSize(8);
                        linha.RelativeItem().Text("Preço").FontSize(8);
                        linha.RelativeItem().Text("Total").FontSize(8).AlignRight();
                    });
                    coluna.Item().LineHorizontal(0.5f);
                    for (int i = 0; i < items.Count; i++)
                    {
                        coluna.Item().Row(linha =>
                        {
                            Item item = items[i];
                            linha.RelativeItem().Text((i+1).ToString()).FontSize(8);
                            linha.RelativeItem(3).Text(item.nome).FontSize(8);
                            linha.RelativeItem(3).Text(item.marca).FontSize(8);
                            linha.RelativeItem().Text(item.quantidade.ToString()).FontSize(8);
                            linha.RelativeItem().Text(item.valorReal.ToString("F2")).FontSize(8);
                            linha.RelativeItem().Text((item.subTotal).ToString("F2")).FontSize(8).AlignRight();
                        });
                    }
                    coluna.Item().LineHorizontal(0.5f);
                    Decimal Total=items.Sum(itens => itens.subTotal);
                    coluna.Item().Row(Linha =>
                    {
                        Linha.RelativeItem().Text("Total").FontSize(8).Bold();
                        Linha.RelativeItem().Text($"{Total:C2}").AlignRight().FontSize(8).Bold();
                    });
                });


                pagina.Footer().Column(coluna =>
                {
                    Funcionario? funcionario = Sessao.usuarioAutenticado;
                    string nome = (funcionario != null) ? funcionario.nome : "";
                    coluna.Item().LineHorizontal(0.5f);
                    coluna.Item().AlignCenter().Text(data).FontSize(10);
                    coluna.Item().AlignCenter().Text("Obrigado pela Preferencia");
                    coluna.Item().AlignCenter().Text(nome).FontSize(10).Bold();
                    coluna.Item().AlignCenter().Text("todos os produtos e funcionarios tem um pasado duvidoso").FontSize(0.5f);



                });
            });
            });
            return documento;
    
    }
    public void SalvarPDF(Document documento)
        {
            
            string pasta = Path.GetTempPath();
            string nomeArquivo = $"Little_Note_{Guid.NewGuid()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo);

            
            documento.GeneratePdf(caminho);
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });


        }
    }

}
