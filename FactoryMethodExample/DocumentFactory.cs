public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

public class WordFactory : DocumentFactory
{
    public override Document CreateDocument() => new WordDocument();
}

public class PdfFactory : DocumentFactory
{
    public override Document CreateDocument() => new PdfDocument();
}

public class ExcelFactory : DocumentFactory
{
    public override Document CreateDocument() => new ExcelDocument();
}
