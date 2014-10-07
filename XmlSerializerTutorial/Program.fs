module XmlSerializationTutorial.Program

open System
open System.IO
open System.Xml
open System.Xml.Schema
open System.Xml.Serialization
open System.Windows.Forms
open XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid

[<EntryPoint>]
let main _ = 
    try
        use schemaReader = XmlReader.Create("AnnaIsikuKvalifikatsioonid.xsd")

        let schemas = XmlSchemaSet()
        schemas.Add(XmlSchema.Read(schemaReader, ValidationEventHandler(fun _ _ -> ()))) |> ignore

        let settings = XmlReaderSettings(Schemas=schemas,
                                         ValidationType=ValidationType.Schema,
                                         ValidationFlags=(XmlSchemaValidationFlags.ProcessIdentityConstraints ||| XmlSchemaValidationFlags.ReportValidationWarnings))
        settings.ValidationEventHandler.Add(fun args ->
            match args.Severity with
            | XmlSeverityType.Warning -> Console.WriteLine(args.Message)
            | _ -> Console.WriteLine(args.Exception.ToString()))

        use input = new StreamReader("AnnaIsikuKvalifikatsioonidParing.xml")
        use reader = XmlReader.Create(input, settings)
        let serializer = XmlSerializer(typeof<AnnaIsikuKvalifikatsioonidParing>)
        let paring = serializer.Deserialize(reader) :?> AnnaIsikuKvalifikatsioonidParing

        match paring.ItemElementName with
        | ItemChoiceType.AsjaNR ->
            MessageBox.Show(sprintf "Otsing Asja numbri '%s' alusel ..." paring.Item) |> ignore
        | ItemChoiceType.Viitenumber ->
            MessageBox.Show(sprintf "Otsing viitenumbri '%s' alusel ..." paring.Item) |> ignore
        | _ ->
            MessageBox.Show("Tundmatu elemendi tüüp!") |> ignore
    with
    | :? XmlException as xe ->
        MessageBox.Show(xe.Message, "XML Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
    | :? InvalidOperationException as ioe ->
        MessageBox.Show(ioe.InnerException.Message, "XML Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
    | e ->
        MessageBox.Show(e.Message, "Other Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
    0
