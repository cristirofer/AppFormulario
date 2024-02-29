using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using iText.Forms;
using iText.Kernel.Pdf;
using System.Web;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace AppFormulario.Presentacion
{
    public class PDFFiller
    {
        public byte[] FillPdfForm(string templatePath, PdfFormData formData)
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    PdfReader reader = new PdfReader(templatePath);
                    PdfWriter writer = new PdfWriter(memoryStream);
                    PdfDocument pdf = new PdfDocument(reader, writer);
                    PdfAcroForm form = PdfAcroForm.GetAcroForm(pdf, true);

                    foreach (var fieldData in formData.FieldData)
                    {
                        form.GetField(fieldData.Key).SetValue(fieldData.Value);
                    }

                    pdf.Close();

                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al rellenar el formulario PDF: {ex.Message}");
                return null;
            }
        }

        public void DownloadPdf(byte[] pdfData, string fileName)
        {/* 
            try
            {
               HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ContentType = "application/pdf";
                HttpContext.Current.Response.AddHeader("content-disposition", $"attachment;filename={fileName}.pdf");
                HttpContext.Current.Response.Buffer = true;
                HttpContext.Current.Response.BinaryWrite(pdfData);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descargar el PDF: {ex.Message}");
            }
            */
        }
    }

    public class PdfFormData
    {
        public PdfFormData()
        {
            FieldData = new System.Collections.Generic.Dictionary<string, string>();
        }

        public System.Collections.Generic.Dictionary<string, string> FieldData { get; set; }
    }
}

