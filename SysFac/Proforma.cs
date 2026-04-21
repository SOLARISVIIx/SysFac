using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SysFac
{
    internal class Proforma
    {
        public static void GenerarProformaPDF(DataTable det, string cliente, string telefono, string ruc, string total)
        {
            try
            {
                float anchoTicketPuntos = 226.77f; // Aprox 7.5cm

                // Crear carpeta si no existe
                string carpeta = @"C:\Proformas\";
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                string ruta = Path.Combine(carpeta, $"Proforma_{DateTime.Now:yyyyMMddHHmmss}.pdf");

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(new PageSize(anchoTicketPuntos, 842f));
                        page.Margin(10);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(9).FontColor(Colors.Black).FontFamily(Fonts.Verdana));

                        page.Content().Column(col =>
                        {
                            col.Item().Text("PROFORMA").FontSize(14).ExtraBold().AlignCenter();
                            col.Item().Text("SYSFAC S.A.").FontSize(11).Bold().AlignCenter();
                            col.Item().PaddingBottom(5).LineHorizontal(1).LineColor(Colors.Black);

                            col.Item().AlignCenter().Text(x => { x.Span("Cliente: ").Bold(); x.Span(cliente); });
                            col.Item().AlignCenter().Text(x => { x.Span("Tel: ").Bold(); x.Span(telefono); });
                            col.Item().AlignCenter().Text(x => { x.Span("RUC: ").Bold(); x.Span(ruc); });

                            col.Item().PaddingVertical(5).LineHorizontal(0.5f).LineColor(Colors.Grey.Lighten2);

                            col.Item().Table(t =>
                            {
                                t.ColumnsDefinition(cd =>
                                {
                                    cd.RelativeColumn(3);
                                    cd.RelativeColumn(1);
                                    cd.RelativeColumn(1.5f);
                                    cd.RelativeColumn(1.5f);
                                });

                                t.Header(h =>
                                {
                                    h.Cell().Text("Producto").Bold();
                                    h.Cell().AlignCenter().Text("Cant").Bold();
                                    h.Cell().AlignRight().Text("Precio").Bold();
                                    h.Cell().AlignRight().Text("Subtotal").Bold();
                                });

                                foreach (DataRow r in det.Rows)
                                {
                                    t.Cell().Text(r["producto"]?.ToString() ?? "S/N");
                                    t.Cell().AlignCenter().Text(r["cantidad"]?.ToString() ?? "0");
                                    t.Cell().AlignRight().Text(Convert.ToDecimal(r["precio_unitario"]).ToString("N2"));
                                    t.Cell().AlignRight().Text(Convert.ToDecimal(r["subtotal"]).ToString("N2"));
                                }
                            });

                            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);

                            col.Item().AlignRight().Text("I.V.A. Incluido").FontSize(8);
                            col.Item().AlignRight().Text(x =>
                            {
                                x.Span("TOTAL: ").Bold().FontSize(12);
                                x.Span(total).Bold().FontSize(12);
                            });

                            col.Item().PaddingTop(10).AlignCenter().Text(DateTime.Now.ToString("G")).FontSize(8);
                            col.Item().AlignCenter().Text("Documento sin validez fiscal").FontSize(8).Italic();
                            col.Item().PaddingTop(5).AlignCenter().Text("¡Gracias por su preferencia!").FontSize(9).Bold();
                        });
                    });
                }).GeneratePdf(ruta);

                Process.Start(new ProcessStartInfo { FileName = ruta, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error Crítico en PDF: " + ex.Message + "\nDetalle: " + ex.InnerException?.Message);
            }
        }
    }
}
