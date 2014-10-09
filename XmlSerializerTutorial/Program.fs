module XmlSerializationTutorial.Program

open System
open System.IO
open System.Xml
open System.Xml.Schema
open System.Xml.Serialization
open System.Windows.Forms
open XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid

let RussianDoll (schemaName : string) (xmlName : string) func =
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
    RussianDoll "AnnaIsikuKvalifikatsioonid.xsd"
                "AnnaIsikuKvalifikatsioonidParing.xml"
                (fun (value : AnnaIsikuKvalifikatsioonidParing) ->
                    match value.ItemElementName with
                    | ItemChoiceType.AsjaNR ->
                        printfn "Otsing Asja numbri '%s' alusel ..." value.Item
                    | ItemChoiceType.Viitenumber ->
                        printfn "Otsing viitenumbri '%s' alusel ..." value.Item
                    | _ ->
                        printfn "Tundmatu elemendi tüüp!")

    printfn "----------"
    RussianDoll "AnnaIsikuKvalifikatsioonid.xsd"
                "AnnaIsikuKvalifikatsioonidVastus.xml"
                (fun (value : AnnaIsikuKvalifikatsioonidVastus) ->
                    printfn "Näitan infot asja nr. %s kohta." value.AsjaNR
                    printfn "Asjas on %d menetlust." value.Menetlused.Length
                    let alus = value.Menetlused.[0].Toimingud.[0].Alused.[0]
                    printfn "Toimingu aluse alguskuupäev on %s." (alus.AlgusKP.GetValueOrDefault().ToString("dd.MM.yyyy")))

    printfn "=========="
    RussianDoll "AnnaIsikuKvalifikatsioonid2.xsd"
                "AnnaIsikuKvalifikatsioonidParing.xml"
                (fun (value : AnnaIsikuKvalifikatsioonidParing) ->
                    match value.ItemElementName with
                    | ItemChoiceType.AsjaNR ->
                        printfn "Otsing Asja numbri '%s' alusel ..." value.Item
                    | ItemChoiceType.Viitenumber ->
                        printfn "Otsing viitenumbri '%s' alusel ..." value.Item
                    | _ ->
                        printfn "Tundmatu elemendi tüüp!")

    printfn "----------"
    RussianDoll "AnnaIsikuKvalifikatsioonid2.xsd"
                "AnnaIsikuKvalifikatsioonidVastus.xml"
                (fun (value : AnnaIsikuKvalifikatsioonidVastus) ->
                    printfn "Näitan infot asja nr. %s kohta." value.AsjaNR
                    printfn "Asjas on %d menetlust." value.Menetlused.Length
                    let alus = value.Menetlused.[0].Toimingud.[0].Alused.[0]
                    printfn "Toimingu aluse alguskuupäev on %s." (alus.AlgusKP.GetValueOrDefault().ToString("dd.MM.yyyy")))
    0
