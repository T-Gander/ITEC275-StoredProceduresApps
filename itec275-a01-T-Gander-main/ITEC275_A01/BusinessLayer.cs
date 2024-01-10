using ITEC275_A01;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC275_A01
{
    public class BusinessLayer : DataLayer
    {
        string[] categoryParams = { "@CategoryName", "@Description" };
        string[] customerParams = { "@CustomerID" };

        List<object> info = new List<object>();

        public DataTable SelectCustomersByCustomerID(string customerID)
        {
            info.Add(customerID);

            return ExecuteStoredProcedureWithParamsReturnDataTable("SelectCustomersByCustomerID", customerParams, info.ToArray());
        }

        public bool InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee(string customerID)
        {
            info.Add(customerID);

            return ExecuteStoredProcedureWithParams("InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee", new string[] { "@CustomerID" }, info.ToArray());      //Check
        }

        public bool UpdateProductUnitPriceByProductID(int productID, decimal unitPrice)
        {
            info.Add(productID);
            info.Add(unitPrice);

            return ExecuteStoredProcedureWithParams("UpdateProductUnitPriceByProductID", new string[] { "@ProductID", "@UnitPrice" }, info.ToArray());      //Check
        }

        public DataTable SelectAllOrdersWithOrderDetails()
        {
            return ExecuteStoredProcedureReturnDataTable("SelectAllOrdersWithOrderDetails");     //Check
        }

        public DataTable SelectProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            info.Add(minPrice);
            info.Add(maxPrice);

            return ExecuteStoredProcedureWithParamsReturnDataTable("SelectProductsByPriceRange", new string[] { "@PriceMin", "@PriceMax" }, info.ToArray());     //Check
        }

        public bool UpdateCustomerPhoneByCustomerID(string customerID, string phone)
        {
            info.Add(customerID);
            info.Add(phone);

            return ExecuteStoredProcedureWithParams("UpdateCustomerPhoneByCustomerID", new string[] { "@CustomerID", "@Phone" }, info.ToArray());        //Check
        }

        public bool InsertNewCategory(string categoryName, string description)
        {
            info.Add(categoryName);
            info.Add(description);

            return ExecuteStoredProcedureWithParams("InsertNewCategory", categoryParams, info.ToArray());       
        }

        public DataTable SelectAllCategories()
        {
            return ExecuteStoredProcedureReturnDataTable("SelectAllCategories");
        }
    }
}
