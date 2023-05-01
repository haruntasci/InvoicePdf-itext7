using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Diagnostics;

namespace InvoicePdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/Users/harun/Desktop/PDFs/invoice.pdf";
            string imagepath = @"C:/Users/harun/Desktop/PDFs/logo.png";

            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Image logo = new Image(ImageDataFactory.Create(imagepath));
            logo.SetHeight(40);
            logo.SetWidth(40);
            logo.SetFixedPosition(122, 775);

            float col = 300f;
            float[] colWidth = {col, col};
            Table table = new Table(colWidth);



            Cell cell11 = new Cell(1, 1)
                .SetFontSize(14)
                .SetBold()
                .SetBorder(Border.NO_BORDER)
                .Add(logo)
                .Add(new Paragraph("MySuperStor"));

            Cell cell12 = new Cell(2, 1)
                 .SetBorder(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetFontSize(26)
                 .Add(new Paragraph("INVOICE"));

            Cell cell21 = new Cell(1, 1)
               .SetBorder(Border.NO_BORDER)
               .SetItalic()
               .Add(new Paragraph("All in one store"));
           

            Table companyInfoTable = new Table(colWidth);
            companyInfoTable.SetMarginTop(20f);

            Cell cell31 = new Cell(1, 1)
                .SetFontSize(8)
                .SetBorder(Border.NO_BORDER)
                .SetItalic()
                .Add(new Paragraph("Dummy Street\nDummy City, 12345\n00 11 22 33 44 55\nlorem@ipsum.co | loren.co"));

            Cell cell32 = new Cell(1, 1)
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT)
                .Add(new Paragraph("INVOICE# 15984125\nDATE April 4,2022"));

            Cell cell41 = new Cell(1, 1)
               .SetFontSize(8)
               .SetBorder(Border.NO_BORDER)
               .SetPaddingTop(20f)
               .SetItalic()
               .Add(new Paragraph("TO\nMr.Lorem Ipsum\nDummy Company\nStreet ABC 123\nLoren Ipsum\n55 44 33 22 44 11"));


            Table itemTable = new Table(colWidth)
                .SetMarginTop(20f);

                Cell cell51 = new Cell(1, 1)
                    .SetBold()
                    .SetBorderLeft(Border.NO_BORDER)
                    .Add(new Paragraph("Description"));

                Cell cell52 = new Cell(1, 1)
                    .SetBold()
                    .SetBorderRight(Border.NO_BORDER)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph("Amount"));

                Cell cell61 = new Cell(1, 1)
                    .SetBorderLeft(Border.NO_BORDER)
                    .Add(new Paragraph("Cooking Oil"));

                Cell cell62 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("540"));

                Cell cell71 = new Cell(1, 1)
                  .SetBorderLeft(Border.NO_BORDER)
                  .Add(new Paragraph("Hair Shampoo"));

                Cell cell72 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("25"));

                Cell cell81 = new Cell(1, 1)
                .SetBorderLeft(Border.NO_BORDER)
                .Add(new Paragraph("Ketchup"));

                Cell cell82 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("15"));

                Cell cell91 = new Cell(1, 1)
                .SetBorderLeft(Border.NO_BORDER)
                .Add(new Paragraph("Yogurt"));

                Cell cell92 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("10"));

                Cell cell101 = new Cell(1, 1)
                 .SetBorderLeft(Border.NO_BORDER)
                 .Add(new Paragraph("Soup"));

                Cell cell102 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("65"));

                Cell cell111 = new Cell(1, 1)
                .SetBorderLeft(Border.NO_BORDER)
                .Add(new Paragraph("Salad"));

                Cell cell112 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("95"));

                Cell cell121 = new Cell(1, 1)
               .SetBorderLeft(Border.NO_BORDER)
               .Add(new Paragraph("Toothpaste"));

                Cell cell122 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("33"));

                Cell cell131 = new Cell(1, 1)
                 .SetBorderLeft(Border.NO_BORDER)
                 .Add(new Paragraph("Baby Car Toy"));

                Cell cell132 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("51"));


                Cell cell141 = new Cell(1, 1)
                 .SetBorderLeft(Border.NO_BORDER)
                 .Add(new Paragraph("Book"));

                Cell cell142 = new Cell(1, 1)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("45"));

            Cell cell151 = new Cell(1, 1)
                  .SetBold()
                  .SetBorderLeft(Border.NO_BORDER)
                  .SetBorderRight(Border.NO_BORDER)
                  .Add(new Paragraph("Total"));

            Cell cell152 = new Cell(1, 1)
                 .SetBold()
                 .SetBorderLeft(Border.NO_BORDER)
                 .SetBorderRight(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .Add(new Paragraph("$ 879"));

            Cell cell161 = new Cell(1, 2)
                .SetBorder(Border.NO_BORDER)
                .SetPaddingTop(20f)
                .Add(new Paragraph("Make all checks payable to MySuperStore\nPayment is due within 30 days.\nIf you have any questions concerning this invoice, contact 00 11 22 33 44 55 | lorem@ipsum.co"));

            Cell cell171 = new Cell(1, 2)
               .SetBorder(Border.NO_BORDER)
               .SetPaddingTop(20f)
               .SetTextAlignment (TextAlignment.CENTER)
               .Add(new Paragraph("THANK YOU FOR YOUR BUSINESS"));



            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell21);


            companyInfoTable.AddCell(cell31);
            companyInfoTable.AddCell(cell32);
            companyInfoTable.AddCell(cell41);

            itemTable.AddCell(cell51);
            itemTable.AddCell(cell52);
            itemTable.AddCell(cell61);
            itemTable.AddCell(cell62);
            itemTable.AddCell(cell71);
            itemTable.AddCell(cell72);
            itemTable.AddCell(cell81);
            itemTable.AddCell(cell82);
            itemTable.AddCell(cell91);
            itemTable.AddCell(cell92);
            itemTable.AddCell(cell101);
            itemTable.AddCell(cell102);
            itemTable.AddCell(cell111);
            itemTable.AddCell(cell112);
            itemTable.AddCell(cell121);
            itemTable.AddCell(cell122);
            itemTable.AddCell(cell131);
            itemTable.AddCell(cell132);
            itemTable.AddCell(cell141);
            itemTable.AddCell(cell142);
            itemTable.AddCell(cell151);
            itemTable.AddCell(cell152);
            itemTable.AddCell(cell161);
            itemTable.AddCell(cell171);

            document.Add(table);
            document.Add(companyInfoTable);
            document.Add(itemTable);
            
            document.Close();
            //Process.Start(path);
        }
    }
}