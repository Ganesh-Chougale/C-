using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine("Your generated password is: " + password.ToString());