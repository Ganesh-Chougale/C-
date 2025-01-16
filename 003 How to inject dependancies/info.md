url = `https://www.nuget.org/`  
##### Preview:  
![](../z_images/003.png)  
search the dependancy you want to inject, then enter  
##### Preview:  
![](../z_images/004.png)  
open the dependancy page & copy the command  
##### Preview:  
![](../z_images/005.png)  
then paste it in project home terminal & ENTER  
##### Preview:  
![](../z_images/006.png)  
```C#
using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine("Your generated password is: " + password.ToString());
```  
##### Preview:  
![](../z_images/007.png)  