﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese_old.Controllers
{
    public partial class EtsReqController : Controller
    {
        // GET: EtsReq 중국 배송신청 팝업
        public ActionResult EtsReqChninfo()
        {
            return View();
        }
    }
}