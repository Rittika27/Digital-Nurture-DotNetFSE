DocumentFactory[] factories = { new WordFactory(), new PdfFactory(), new ExcelFactory() };

foreach (var factory in factories)
{
    Document doc = factory.CreateDocument();
    doc.Open();
}
