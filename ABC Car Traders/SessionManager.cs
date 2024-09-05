using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    public static class SessionManager
    {
        public static string LoggedInEmail { get; set; }
        public static bool IsAdmin { get; set; }



        // New properties to store logged-in customer's details
        public static string CustomerID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static int LoggedInCustomerId { get; set; }
        public static string AdminID { get; private set; }

        // Method to set customer details after login
        public static void SetCustomerDetails(string customerID, string firstName, string lastName, string email, bool isAdmin)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = Password;
            IsAdmin = isAdmin;

        }

        // Method to clear customer details on logout
        public static void ClearSession()
        {
            CustomerID = null;
            FirstName = null;
            LastName = null;
            Email = null;
            Password = null;
            
        }

        public static void SetAdminDetails(string adminId, string email)
        {
            AdminID = adminId;
            
            LoggedInEmail = email;
            IsAdmin = true;
        }
    }
}
