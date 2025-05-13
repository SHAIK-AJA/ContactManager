using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ContactManager.Models;

namespace ContactManager.Services
{
    public class PdfService
    {
        public byte[] GenerateContactPdf(Contact contact)
        {
            using (var stream = new MemoryStream())
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
           
                doc.Add(new Paragraph("Contact Details"));
                doc.Add(new Paragraph($"Name: {contact.FirstName} {contact.SurName}"));
                doc.Add(new Paragraph($"Phone: {contact.PhoneNumber}"));
                doc.Add(new Paragraph($"Email: {contact.Gmail}"));
                doc.Add(new Paragraph($"Company: {contact.Company}"));
                doc.Add(new Paragraph($"Notes: {contact.Notes}"));

                doc.Close();
                return stream.ToArray();
            }
        }
    }
}
