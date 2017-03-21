        Dim document As XmlDocument = New XmlDocument()
        document.Load("contosoBooks.xml")
        Dim navigator As XPathNavigator = document.CreateNavigator()

        navigator.MoveToChild("bookstore", "http://www.contoso.com/books")
        navigator.MoveToChild("book", "http://www.contoso.com/books")
        navigator.MoveToChild("price", "http://www.contoso.com/books")

        navigator.InsertElementBefore(navigator.Prefix, "pages", navigator.LookupNamespace(navigator.Prefix), "100")

        navigator.MoveToParent()
        Console.WriteLine(navigator.OuterXml)