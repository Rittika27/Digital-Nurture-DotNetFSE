DocumentFactory factory;

factory = new WordDocumentFactory();
Document doc1 = factory.CreateDocument();
doc1.Open();

factory = new PdfDocumentFactory();
Document doc2 = factory.CreateDocument();
doc2.Open();

factory = new ExcelDocumentFactory();
Document doc3 = factory.CreateDocument();
doc3.Open();
