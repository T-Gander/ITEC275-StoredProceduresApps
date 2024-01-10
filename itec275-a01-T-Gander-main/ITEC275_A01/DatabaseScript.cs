using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCLI
{
    internal class DatabaseScript
    {
        public string CreateDatabaseStoredProceduresScript;

        internal DatabaseScript()
        {
            CreateDatabaseStoredProceduresScript = @"

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[DeleteCategoryByID]    Script Date: 1/9/2024 10:21:55 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to Delete a category.
			-- =============================================
			CREATE PROCEDURE [dbo].[DeleteCategoryByID]
				-- Add the parameters for the stored procedure here
				@CategoryID int
			AS
			BEGIN
	
				delete from Categories
				where [CategoryID] = @CategoryID

			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[InsertNewCategory]    Script Date: 1/9/2024 10:23:53 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to insert an new category.
			-- =============================================
			CREATE PROCEDURE [dbo].[InsertNewCategory]
				-- Add the parameters for the stored procedure here
				@CategoryName nvarchar(15),
				@Description ntext
			AS
			BEGIN
	
				Insert into Categories
				Values (@CategoryName, @Description, 0x)

			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee]    Script Date: 1/9/2024 10:24:02 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to Insert an order of ten units of chai with a random employeeid.
			-- =============================================
			CREATE PROCEDURE [dbo].[InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee]
				-- Add the parameters for the stored procedure here
				@CustomerID nvarchar(5)
			AS
			BEGIN

				Declare @ChaiProductID int;
				Declare @ChaiUnitPrice money;
				Declare @OrderID int;

				select @ChaiProductID = ProductID,
						@ChaiUnitPrice = UnitPrice
				from products
				where ProductName = 'Chai'

				select @OrderID = Max(OrderID)+1
				from Orders

				Insert into Orders (CustomerID, EmployeeID)
				Values (@CustomerID, FLOOR(RAND()*(10-1)+1))

				Insert into [Order Details]
				Values (@OrderID, 1, @ChaiUnitPrice, 10, 0)

			END

			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[SelectAllFromCategories]    Script Date: 1/9/2024 10:24:14 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to read all categories.
			-- =============================================
			CREATE PROCEDURE [dbo].[SelectAllFromCategories]
				-- Add the parameters for the stored procedure here
			AS
			BEGIN
	
				Select * from [Categories]

			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[SelectAllOrdersWithOrderDetails]    Script Date: 1/9/2024 10:24:23 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to select products within a Price Range.
			-- =============================================
			CREATE PROCEDURE [dbo].[SelectAllOrdersWithOrderDetails]
				-- Add the parameters for the stored procedure here
	
			AS
			BEGIN
				Select o.OrderID, o.CustomerID, o.EmployeeID, Sum(od.UnitPrice * Quantity) [Total Sum of Order] from Orders o
				inner join [Order Details] od on o.OrderID = od.OrderID
				Group by o.OrderID, o.CustomerID, o.EmployeeID
			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[SelectAllProducts]    Script Date: 1/9/2024 10:24:31 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas Gander
			-- Create date: 1/9/2024
			-- Description:	Select all products
			-- =============================================
			CREATE PROCEDURE [dbo].[SelectAllProducts] 
				-- Add the parameters for the stored procedure here
	
			AS
			BEGIN
				-- SET NOCOUNT ON added to prevent extra result sets from
				-- interfering with SELECT statements.
				SET NOCOUNT ON;

				-- Insert statements for procedure here
				SELECT * from Products
			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[SelectCustomersByCustomerID]    Script Date: 1/9/2024 10:25:38 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to select a Customer by CustomerID.
			-- =============================================
			CREATE PROCEDURE [dbo].[SelectCustomersByCustomerID]
				-- Add the parameters for the stored procedure here
				@CustomerID nvarchar(5)
			AS
			BEGIN
	
				Select * from Customers
				where CustomerID = @CustomerID

			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[SelectProductsByPriceRange]    Script Date: 1/9/2024 10:25:48 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to select products within a Price Range.
			-- =============================================
			CREATE PROCEDURE [dbo].[SelectProductsByPriceRange]
				-- Add the parameters for the stored procedure here
				@PriceMin decimal,
				@PriceMax decimal
			AS
			BEGIN
				Select * from Products
				where [UnitPrice] <= @PriceMax AND [UnitPrice] >= @PriceMin
			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[UpdateCategoryByID]    Script Date: 1/9/2024 10:25:57 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to update a category.
			-- =============================================
			CREATE PROCEDURE [dbo].[UpdateCategoryByID]
				-- Add the parameters for the stored procedure here
				@CategoryId int,
				@CategoryName nvarchar(15),
				@Description ntext,
				@Picture image
			AS
			BEGIN
	
				Update Categories
				Set [CategoryName] = @CategoryName, [Description] = @Description, [Picture] = @Picture
				where [CategoryID] = @CategoryId

			END
			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[UpdateCustomerPhoneByCustomerID]    Script Date: 1/9/2024 10:26:05 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to update a Customers phone number by customer id.
			-- =============================================
			CREATE PROCEDURE [dbo].[UpdateCustomerPhoneByCustomerID]
				-- Add the parameters for the stored procedure here
				@CustomerID nvarchar(5),
				@Phone nvarchar(24)
			AS
			BEGIN
	
				Update Customers
				Set Phone = @Phone
				Where CustomerID = @CustomerID

			END

			GO

			USE [NwindDB]
			GO
			/****** Object:  StoredProcedure [dbo].[UpdateProductUnitPriceByProductID]    Script Date: 1/9/2024 10:26:13 AM ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			-- =============================================
			-- Author:		Thomas
			-- Create date: Jan 3 2024
			-- Description:	Used to Update a products unit price with a supplied product id and unit price.
			-- =============================================
			CREATE PROCEDURE [dbo].[UpdateProductUnitPriceByProductID]
				-- Add the parameters for the stored procedure here
				@ProductID int,
				@UnitPrice money
			AS
			BEGIN
	
				Update Products
				Set UnitPrice = @UnitPrice
				Where ProductID = @ProductID

			END


			";


        }
    }
}
