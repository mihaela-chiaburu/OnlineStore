﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Response
{
    public class URegisterResp
    {
        public string ActionStatusMsg { get; set; }
        public bool Status { get; set; }
        public User.DBModel.User CurrentUser { get; set; }
    }
}
