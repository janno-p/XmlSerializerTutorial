module XmlSerializationTutorial.Program

open System
open System.IO
open System.Xml
open System.Xml.Schema
open System.Xml.Serialization
open System.Windows.Forms

let deserialize (schemaName : string) (xmlName : string) func =
    try
        use schemaReader = XmlReader.Create(schemaName)

        let schemas = XmlSchemaSet()
        schemas.Add(XmlSchema.Read(schemaReader, ValidationEventHandler(fun _ _ -> ()))) |> ignore

        let settings = XmlReaderSettings(Schemas=schemas,
                                         ValidationType=ValidationType.Schema,
                                         ValidationFlags=(XmlSchemaValidationFlags.ProcessIdentityConstraints ||| XmlSchemaValidationFlags.ReportValidationWarnings))

        settings.ValidationEventHandler.Add(fun args ->
            match args.Severity with
            | XmlSeverityType.Warning -> Console.WriteLine(args.Message)
            | _ -> Console.WriteLine(args.Exception.ToString()))

        use input = new StreamReader(xmlName)
        use reader = XmlReader.Create(input, settings)

        let serializer = XmlSerializer(typeof<'T>)
        serializer.Deserialize(reader) :?> 'T |> func
    with
    | :? XmlException as xe ->
        MessageBox.Show(xe.Message, "XML Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
    | :? InvalidOperationException as ioe ->
        MessageBox.Show(ioe.InnerException.Message, "XML Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
    | e ->
        MessageBox.Show(e.Message, "Other Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore


[<EntryPoint>]
let main _ = 
    printfn "=========="
    deserialize "AnnaIsikuKvalifikatsioonid.xsd"
                "AnnaIsikuKvalifikatsioonidParing.xml"
                (fun (value : XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid.AnnaIsikuKvalifikatsioonidParing) ->
                    match value.ItemElementName with
                    | XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid.ItemChoiceType.AsjaNR ->
                        printfn "Otsing Asja numbri '%s' alusel ..." value.Item
                    | XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid.ItemChoiceType.Viitenumber ->
                        printfn "Otsing viitenumbri '%s' alusel ..." value.Item
                    | _ ->
                        printfn "Tundmatu elemendi tüüp!")

    printfn "----------"
    deserialize "AnnaIsikuKvalifikatsioonid.xsd"
                "AnnaIsikuKvalifikatsioonidVastus.xml"
                (fun (value : XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid.AnnaIsikuKvalifikatsioonidVastus) ->
                    printfn "Näitan infot asja nr. %s kohta." value.AsjaNR
                    printfn "Asjas on %d menetlust." value.Menetlused.Length
                    let alus = value.Menetlused.[0].Toimingud.[0].Alused.[0]
                    printfn "Toimingu aluse alguskuupäev on %s." (alus.AlgusKP.GetValueOrDefault().ToString("dd.MM.yyyy")))

    printfn "=========="
    deserialize "AnnaIsikuKvalifikatsioonid2.xsd"
                "AnnaIsikuKvalifikatsioonidParing.xml"
                (fun (value : XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid2.AnnaIsikuKvalifikatsioonidParing) ->
                    match value.ItemElementName with
                    | XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid2.ItemChoiceType.AsjaNR ->
                        printfn "Otsing Asja numbri '%s' alusel ..." value.Item
                    | XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid2.ItemChoiceType.Viitenumber ->
                        printfn "Otsing viitenumbri '%s' alusel ..." value.Item
                    | _ ->
                        printfn "Tundmatu elemendi tüüp!")

    printfn "----------"
    deserialize "AnnaIsikuKvalifikatsioonid2.xsd"
                "AnnaIsikuKvalifikatsioonidVastus.xml"
                (fun (value : XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid2.AnnaIsikuKvalifikatsioonidVastus) ->
                    printfn "Näitan infot asja nr. %s kohta." value.AsjaNR
                    printfn "Asjas on %d menetlust." value.Menetlused.Length
                    let alus = value.Menetlused.[0].Toimingud.[0].Alused.[0]
                    printfn "Toimingu aluse alguskuupäev on %s." (alus.AlgusKP.GetValueOrDefault().ToString("dd.MM.yyyy")))
    0
