using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModel
{
    public class NewCustomerViewModel
    {
        // we used IEnumberable here cause we don't need to use any functionality of the list class (index , ...)
        public IEnumerable<MembershipType> MembershipTypes {get; set; }
        public Customer Customer { get; set; }
    }
}