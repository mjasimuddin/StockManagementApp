using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagementSystemApp.Model;
using Font = System.Drawing.Font;

namespace StockManagementSystemApp.Model
{
    class PdfSalesManager
    {
        private PdfDateRange PdfRange = new PdfDateRange();
        
        public static string GenerateItemSalesPdf(ListView salesListView)
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

                //para = new Paragraph("Sales from ("+UI.ViewSales.PdfRange.FromDate.ToShortDateString()+") to ("+UI.ViewSales.PdfRange.ToDate.ToShortDateString()+")", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10f, BaseColor.BLACK));
                //para.Alignment = Element.ALIGN_CENTER;
                //para.SpacingBefore = 5;
                //para.SpacingAfter = 10;
                //document.Add(para);

                PdfPTable table = new PdfPTable(4);
                PdfPCell cell = new PdfPCell(new Phrase("SL.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("ITEM", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                cell.Colspan = 2;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("QUANTITY", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(0, 0, 0);
                table.AddCell(cell);
                int rowcount = 0;
                foreach (ListViewItem viewItem in salesListView.Items)
                {
                    ViewSalesReport item = (ViewSalesReport)viewItem.Tag;
                    PdfPCell inCell = new PdfPCell(new Phrase((++rowcount).ToString()));
                    inCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(inCell);

                    inCell = new PdfPCell(new Phrase(item.ItemName.Trim()));
                    inCell.Colspan = 2;
                    table.AddCell(inCell);

                    inCell = new PdfPCell(new Phrase(item.Quantity.ToString()));
                    inCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(inCell);
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
