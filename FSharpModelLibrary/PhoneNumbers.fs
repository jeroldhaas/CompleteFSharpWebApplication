namespace FSharpModelLibrary


type StringOfNumbers(phoneNumber: string) =
    [<DefaultValue>] val mutable numberString : string
    

type Address = {
    AddressFirstLine    : string;
    AddressSecondLine   : string;
    AddressThirdLine    : string;
    City                : string;
    State               : string;
    County              : string;
    MailingCode         : string;
    Country             : string;
}

type ContactInformation = {
    FirstName   : string;
    LastName    : string;
    MiddleName  : string;
    Addresses   : List<string>;

}

type Contact = {
    Contact     : ContactInformation;
    PhoneNumbers : List<StringOfNumbers>;
}

