namespace CompleteFSharpWebApplication.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

type PhoneNumbersController() =
    inherit Controller()
    member this.Index () = this.View()