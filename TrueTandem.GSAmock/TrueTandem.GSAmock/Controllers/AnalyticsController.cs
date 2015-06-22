using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrueTandem.GSAmock.Models;

namespace TrueTandem.GSAmock.Controllers
{
    /// <summary>
    /// The analytics controller.
    /// </summary>
    public class AnalyticsController : Controller
    {
        /// <summary>
        /// Indexes the specified chart.
        /// </summary>
        /// <param name="section">The section.</param>
        /// <returns>The analytics view.</returns>
        public ActionResult Chart(int section = 0)
        {
            return this.View(new AnalyticsIndexModel
            {
                Title = "Analytics",
                Section = section
            });
        }
    }
}