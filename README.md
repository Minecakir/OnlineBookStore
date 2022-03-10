# OnlineBookStore

### [1. PROJECT DESCRIPTION](https://github.com/Minecakir/OnlineBookStore/edit/main/README.md#project-description)

### [2. DESİGN](https://github.com/Minecakir/OnlineBookStore/edit/main/README.md#design)

### [3. UML](https://github.com/Minecakir/OnlineBookStore/edit/main/README.md#-uml-)

### [4. THE WORKS OF TEAM MEMBERS](https://github.com/Minecakir/OnlineBookStore/edit/main/README.md#the-works-of-team-members)

<h2 id="tw-target-text" class="tw-data-text tw-text-large tw-ta" dir="ltr" data-placeholder="&Ccedil;eviri"><span class="Y2IQFc" lang="en" style="color: #ff0000;">1. PROJECT DESCRIPTION</span></h2>

<p style="text-align: justify;"> 
  In this project, we created an online book store desktop application by using C#  programming language. </p> 
  <p align="left">  </p> 
  <p Main expectation of this project is implementing object-oriented programming principles into our work.<br />Our project includes login and signup mechanism which helps protect customers personal data. Inside the application customers can add items to their shopping cart and they can moderate their shopping carts and previous orders. In main page customers can filter products by their types (book, music CD, magazine).<br />In our project we implemented two different object-oriented design patterns. One of them is visitor design pattern and another one is singleton design pattern we will be mentioning this<br />patterns in upcoming chapters.<br />In case of need here is a sample user login information to book store;&nbsp;<br /><strong>UserName</strong>: hcanergun<br /><strong>Password</strong>: hcanergun60</p>
<p style="text-align: justify;">&nbsp;</p>

<h2 style="text-align: justify;">2. DESIGN</h2>
<p>&nbsp;</p>
<h4> 2.1. LOGIN FORM </h4>
  <p> This form is prepared for the customer to login. If customer has username and password that entered the textboxes matches customer’s information on database(sql) he/she logged in. A warning message is shown to the customer if the password or username is entered incorrectly. In case the customer does not have an account, they can click the signup button to create. </p>

 <p align = "center">
  <img src="https://user-images.githubusercontent.com/67970973/155270892-b206524c-898e-48ed-956d-b8d3cd324951.png">
  <img src="https://user-images.githubusercontent.com/67970973/155271336-a2532f09-99b1-4350-9aec-f4f686bc31ff.png">
</p>   

<h4>2.2. MAIN FORM</h4>
<p>&nbsp;</p>

![image](https://user-images.githubusercontent.com/67970973/155274527-6a9222bc-a571-4920-9eb4-a0b1daf456c8.png)

<p>&nbsp;</p>
<p>&nbsp;The orders and shopping card buttons on the main screen are used with the user control classes specified under the UserControls heading. The customer first adds the product he has selected from the main screen to the shopping card by using the Purchase button. With the shopping card button, the products added to the shopping cart will be accessed.</p>

![image](https://user-images.githubusercontent.com/67970973/155269498-49f2bb37-4601-4717-bb3a-dae92f885383.png)
<p>&nbsp;</p><p></p>

![image](https://user-images.githubusercontent.com/67970973/155274631-97398861-c722-4235-8ff0-8460b5733ac9.png)

<p>&nbsp;</p>
<p>&nbsp;The total price of the products is displayed on the screen after the quantity adjustment of the products in the shopping cart is made and saved or the product is removed from the shopping cart. As the last step, the customer buys the products he wants to buy by clicking the Purchase button and displays his orders by clicking the orders button.</p>

<h4>2.3. PAYMENT FORM</h4>
<p>By listing the current and previous orders of the customer mentioned on the screen, the customer can approve the orders. If the order is not canceled here and the customer decides to buy the products, he can do so by pressing the Purchase button. mentioned under the relevant heading. A new form opens on the screen when orders are received. In this form, the customer chooses which method he/she wants to make the payment method and which of the two different methods he/she wants to receive the invoice notification via mail or phone message. In addition, the customer enters the address information and confirms the order.</p>

 <p align = "center">
  <img src="https://user-images.githubusercontent.com/67970973/155271552-3fe8d9aa-0b29-48c9-b6a7-d864351dd30d.png">
  <img src="https://user-images.githubusercontent.com/67970973/155271573-2afc8f09-ec51-48db-a55b-71f0f892df68.png">
</p>   

<h2> 3. UML </h2>

![Class_Diagram](https://user-images.githubusercontent.com/67970973/155271813-a796a508-e440-4849-975d-30781196a705.png)

<h2>4. THE WORKS OF TEAM MEMBERS</h2>
<table style="height: 151px; width: 561.156px;">
<tbody>
<tr>
<td style="width: 176px; text-align: center;">Name - Surname</td>
<td style="width: 22px; text-align: center;">%</td>
<td style="width: 335.156px; text-align: center;">Task</td>
</tr>
<tr>
  
<td style="width: 176px; text-align: center;"><a href="https://github.com/Minecakir">Mine &Ccedil;AKIR</a></td>
<td style="width: 22px; text-align: center;">17</td>
<td style="width: 335.156px; text-align: left;">ItemToPurchase, ShoppingCart, ShoppingCartRepo,<br />UserControl(s), PaymentForm</td>
</tr>
<tr>
<td style="width: 176px; text-align: center;"><a href="https://github.com/M-TalhaSahin">Muhammed Talha ŞAHİN</a></td>
<td style="width: 22px; text-align: center;">19</td>
<td style="width: 335.156px; text-align: left;">ShoppingCart, ItemToPurchaseRepo, ShoppingCartRepo,<br />MainPage</td>
</tr>
<tr>
<td style="width: 176px; text-align: center;"><a href="https://github.com/hcanergun">H&uuml;seyin Can ERG&Uuml;N</a></td>
<td style="width: 22px; text-align: center;">17</td>
<td style="width: 335.156px; text-align: left;">LogIn, SignUp, Customer, CustomerRepo, LoginedUser,<br />DataBase</td>
</tr>
<tr>
<td style="width: 176px; text-align: center;"><a href="https://github.com/melisbozdagg">Ece Melis BOZDAĞ</a></td>
<td style="width: 22px; text-align: center;">15</td>
<td style="width: 335.156px; text-align: left;">Product, Book, ProductRepo, Visitor, UML</td>
</tr>
<tr>
<td style="width: 176px; text-align: center;"><a href="https://github.com/batuhanbay">Mustafa Batuhan BAYOĞLU</a></td>
<td style="width: 22px; text-align: center;">17</td>
<td style="width: 335.156px; text-align: left;">LogIn, SignUp, Customer, DataBase, DBConnection,<br />CustomerRepo, Log</td>
</tr>
<tr>
<td style="width: 176px; text-align: center;">Mislina &Ccedil;ETİNER</td>
<td style="width: 22px; text-align: center;">15</td>
<td style="width: 335.156px; text-align: left;">Magazine, MusicCD, ProductRepo, DataBase, UML</td>
</tr>
</tbody>
</table>


