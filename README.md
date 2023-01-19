# Windows-NIC-LocallyAdminsteredAddress-Generator
Windows 10 NIC network card Locally Adminstered Address Generator for local Network card interface to change the IP Address for HKBN User

How To use:

important remind:

This project is base on C# .net 5 SDK, if you need to modify the code with VS or VSC, please remember to download the .net 5 SDK

URL: https://dotnet.microsoft.com/en-us/download/dotnet/5.0


1. Go to Registry Editor and search "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}" then will have lot of the file and it name with number.
![image](https://user-images.githubusercontent.com/93077307/202847967-1b006800-e303-4802-86c9-3b4bf0bed50e.png)

2. Find your Network NIC interface driver name on control panel > Network > Your Lan Card > Details... > Desciption.
![image](https://user-images.githubusercontent.com/93077307/202848006-ca9a84d5-1664-4df4-98ae-8236a0e99fc4.png)

3. Back to your Registry Editor and find out your NIC interface driver name on those file which is named with number.
![image](https://user-images.githubusercontent.com/93077307/202848240-2b6f23fb-21c7-4179-8d13-ad0167958471.png)

4. Copy the the number and paste on your code editor on the line 20.
![image](https://user-images.githubusercontent.com/93077307/202848124-b0935e71-607a-4926-8ddb-7fa7f20a00c0.png)

5. Export and run on Admin mode then your IP will be changed to new one :)

Hope you enjoy :)

