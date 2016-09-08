open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http

type Startup () =
    member __.Configure (app: IApplicationBuilder) =
      app.Run (fun context ->
        context.Response.WriteAsync ("Hello from ASP.NET Core!"))

[<EntryPoint>]
let main _ =

    try
        WebHostBuilder()
            .UseUrls("http://*:7000")
            .UseKestrel()
            .UseStartup<Startup>()
            .Build()
            .Run()
    with
        | exn ->
            printfn "%A" exn

    0