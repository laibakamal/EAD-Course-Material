baseAddress/User/SignUp

baseaddress=get
User= controller name
sign up= action method


//whenever send request: do it through controller and action method 
1)
<form action = "controllername/actionmethod" method="post">


2)
<a href = "controllername/actionmethod">

________________________________________________________


httppost: ??



function k parameters jo hein, un me username ki jaga username aur password ki jaga password aaye html page se, ye cheez kese deal hogi??
Ans::: user ki class me (model me ) jo properties k naam hein, html k input tag me name whi rkhna hai same.

    //helper tag:
    //server side control which automatcally create user side html for you
    //they are used because there are chances of ghalti in html tags
    <input asp-for = 'Username'/>//asp-for is helper tag for html input tag

    //when using tag helper, we must know k konsa view kis model k againt hai
    //strongly typed view: is view ko pata ha k mere ander konsa wala model use hona hai 














