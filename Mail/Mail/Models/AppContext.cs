using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mail.Models
{
    public class AppContext: DbContext
    {
        public AppContext(): base ("Contact Form")
        {

        }
        public DbSet<ContactForm> ContactForms { get; set; }
    }
}