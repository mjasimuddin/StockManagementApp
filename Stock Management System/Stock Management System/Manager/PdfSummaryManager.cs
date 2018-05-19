using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagementSystemApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.Manager
{
    
    class PdfSummaryManager
    {
        public static string GenerateItemSummaryPdf(ListView summaryListView)
        {
            string result = "";
            try
            {
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "PDF Files | *.pdf";
                svg.DefaultExt = "pdf";
                svg.ShowDialog();

                Document document = new Document(PageSize.A4, 10, 10, 10, 10);

                //PdfWriter writer =
                PdfWriter.GetInstance(document, new FileStream(svg.FileName, FileMode.Create));
                document.Open();

                Paragraph para = new Paragraph("Stock Management System", FontFactory.GetFont("Papyrus", 20f, BaseColor.GRAY));
                para.Alignment = Element.ALIGN_CENTER;
                para.SpacingBefore = 10;
                para.SpacingAfter = 20;
                document.Add(para);

                para = new Paragraph("Print Date: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7f, BaseColor.BLACK));
                para.Alignment = Element.ALIGN_RIGHT;
                para.SpacingBefore = 5;
                para.SpacingAfter = 10;
                document.Add(para);

                para = new Paragraph("Item Summary", FontFactory.GetFont("Arial", 10f, BaseColor.BLACK));
                para.Alignment = Element.ALIGN_CENTER;
                para.SpacingBefore = 5;
                para.SpacingAfter = 10;
                document.Add(para);

                PdfPTable table = new PdfPTable(6);
                PdfPCell cell = new PdfPCell(new Phrase("SI", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Item Name", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Company", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Category", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Ava. Qty", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Reorder L.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);
                int rowcount = 0;
                foreach (ListViewItem viewItem in summaryListView.Items)
                {
                    ViewItemSummary item = (ViewItemSummary)viewItem.Tag;
                    table.AddCell((++rowcount).ToString());
                    table.AddCell(item.ItemName.Trim());
                    table.AddCell(item.CompanyName.Trim());
                    table.AddCell(item.CategoryName.Trim());
                    table.AddCell(item.AvailableQuantity.ToString());
                    table.AddCell(item.ReorderLevel.ToString());
                }
                document.Add(table);
                document.Close();
                result = "A PDF file has been generated";
            }
            catch (Exception ex)
            {
                result = "PDF file did not generate";
            }

            return result;
        }
    }
}
