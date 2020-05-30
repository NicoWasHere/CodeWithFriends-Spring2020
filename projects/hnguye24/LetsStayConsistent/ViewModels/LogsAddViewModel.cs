﻿using LetsStayConsistent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsStayConsistent.ViewModels
{
    public class LogsAddViewModel
    {
        [Display(Name = "Goals")]
        public List<SelectListItem> Goals { get; set; }

        public GoalLog GoalLog { get; set; }

        public int GoalId { get; set; }
    }
}