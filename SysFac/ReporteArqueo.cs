using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SysFac
{
    internal class ReporteArqueo
    {
        public static void GenerarArqueoPDF(
            string caja,
            DateTime fechaInicio,
            DateTime fechaFinal,
            string facturas,
            string totalFacturado,
            string iva,
            string descuentos,
            string efectivo,
            string tarjeta,
            string transferencia,
            string montoEsperado,
            string efectivoContado,
            string diferencia,
            string resultado,
            string observaciones,
            DataGridView dgv)
        {
            try
            {
                string carpeta = @"C:\Arqueos\";

                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                string ruta = Path.Combine(
                    carpeta,
                    $"Arqueo_{DateTime.Now:yyyyMMddHHmmss}.pdf");

                QuestPDF.Settings.License =
                    LicenseType.Community;

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(25);

                        page.Header()
                            .Text("REPORTE DE ARQUEO DE CAJA")
                            .FontSize(18)
                            .Bold()
                            .AlignCenter();

                        page.Content().Column(col =>
                        {
                            col.Spacing(5);

                            col.Item().Text($"Caja: {caja}");
                            col.Item().Text(
                                $"Período: {fechaInicio:dd/MM/yyyy} - {fechaFinal:dd/MM/yyyy}");

                            col.Item().PaddingVertical(5)
                                .LineHorizontal(1);

                            // RESUMEN GENERAL

                            col.Item()
                                .Text("RESUMEN GENERAL")
                                .Bold()
                                .FontSize(14);

                            col.Item().Text($"Facturas Emitidas: {facturas}");
                            col.Item().Text($"Total Facturado: C$ {totalFacturado}");
                            col.Item().Text($"IVA Recaudado: C$ {iva}");
                            col.Item().Text($"Descuentos: C$ {descuentos}");

                            col.Item().PaddingVertical(5)
                                .LineHorizontal(1);

                            // MÉTODOS DE PAGO

                            col.Item()
                                .Text("MÉTODOS DE PAGO")
                                .Bold()
                                .FontSize(14);

                            col.Item().Text($"Efectivo: C$ {efectivo}");
                            col.Item().Text($"Tarjeta: C$ {tarjeta}");
                            col.Item().Text($"Transferencia: C$ {transferencia}");

                            col.Item().PaddingVertical(5)
                                .LineHorizontal(1);

                            // ARQUEO

                            col.Item()
                                .Text("RESULTADO DEL ARQUEO")
                                .Bold()
                                .FontSize(14);

                            col.Item().Text($"Monto Esperado: C$ {montoEsperado}");
                            col.Item().Text($"Efectivo Contado: C$ {efectivoContado}");
                            col.Item().Text($"Diferencia: C$ {diferencia}");
                            col.Item().Text($"Resultado: {resultado}");

                            col.Item().PaddingVertical(5)
                                .LineHorizontal(1);

                            // OBSERVACIONES

                            col.Item()
                                .Text("OBSERVACIONES")
                                .Bold()
                                .FontSize(14);

                            col.Item().Text(
                                string.IsNullOrWhiteSpace(observaciones)
                                ? "Sin observaciones."
                                : observaciones);

                            col.Item().PaddingVertical(5)
                                .LineHorizontal(1);

                            // MOVIMIENTOS

                            col.Item()
                                .Text("MOVIMIENTOS DE CAJA")
                                .Bold()
                                .FontSize(14);

                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Text("Fecha").Bold();
                                    header.Cell().Text("Tipo").Bold();
                                    header.Cell().Text("Monto").Bold();
                                    header.Cell().Text("Factura").Bold();
                                });

                                foreach (DataGridViewRow row in dgv.Rows)
                                {
                                    if (row.IsNewRow)
                                        continue;

                                    table.Cell().Text(
                                        row.Cells["fecha"].Value?.ToString() ?? "");

                                    table.Cell().Text(
                                        row.Cells["tipo"].Value?.ToString() ?? "");

                                    table.Cell().Text(
                                        row.Cells["monto"].Value?.ToString() ?? "");

                                    table.Cell().Text(
                                        row.Cells["id_factura"].Value?.ToString() ?? "");
                                }
                            });

                            col.Item().PaddingTop(15);

                            col.Item()
                                .AlignCenter()
                                .Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

                            col.Item()
                                .AlignCenter()
                                .Text("Documento generado por SysFac")
                                .Italic();
                        });
                    });
                })
                .GeneratePdf(ruta);

                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar PDF:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}