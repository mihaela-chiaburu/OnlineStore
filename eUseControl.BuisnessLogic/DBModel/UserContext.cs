using eUseControl.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BuisnessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=eUseControl") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
