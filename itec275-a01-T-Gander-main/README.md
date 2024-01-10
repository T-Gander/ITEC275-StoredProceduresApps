# ITEC275 Assignment 01
The focus of this assignment is writing SQL code in the form of **stored procedures**

Using the techniques started/demonstrated in class, complete the following additional tasks, please note that square brackets indicate where you should replace content.

For example **[Your Name]** should be replaced with something like: **John** and NOT something like: **[John]**, if you need further clarification please ask.




1. Using the Northwind Database build stored procedures for: Products, Categories, Orders and
Order Details.
[6 marks]

   i. Insert -> InsertNew[Category]

   ii. Delete (by primary key) -> Delete[Category]By[ID]

   iii. Select * -> SelectAllFrom[Category]


2. Using the Northwind Database build the below stored procedures for the needed tables:
[6 marks]

   Give each stored procedure below a descriptive name, and modify this readme to display what you named it.

   i. Select Customers by customer id
   
   SProc Name: SelectCustomersByCustomerID

   ii. Select Products by unit price range (min, max)
   
   SProc Name: SelectProductsByPriceRange

   iii. Select Orders and join Order details to show the order id, customer id, employee id and total price of each Order.
   
   SProc Name: SelectAllOrdersWithOrderDetails

   iv. Insert an Order for a customer id, that will contain ten units of Chai, from a random employee id
   
   SProc Name: InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee

   v. Update a given product id to a new unit price in Products
   
   SProc Name: UpdateProductUnitPriceByProductID

   vi. Update a Customer’s contact phone
   
   SProc Name: UpdateCustomersPhoneByCustomerID

4. Use the class library from this Github repo to utilize all stored procedures defined in the previous question **(question 2)**. All queries should be parameterized in C#.
[6 marks]

5. Create a windows forms UI application to interact with the class created.
[3 marks]

6. Create a console application to interact with the class created.
[3 marks]


Complete this assignment individually, do not share code, focus on writing the requested procedures and C# code.
