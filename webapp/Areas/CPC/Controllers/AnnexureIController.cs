﻿using BaseApp.Entity;
using BaseApp.System;
using CPC;
using CPC.Model;
using ImageResizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApp.Areas.CPC.Controllers
{
    [AppAuthorize(AppPermission.All, AppPermission.ViewCPC, AppPermission.CPC)]
    public class AnnexureIController : AppController
    {
        private AnnexureIEntity annexureIRepo;
        private EmployeeEntity employeeRepo;
        private BranchEntity branchRepo;
        private Common commonRepo;

        public AnnexureIController()
        {
            annexureIRepo = new AnnexureIEntity();
            employeeRepo = new EmployeeEntity();
            branchRepo = new BranchEntity();
            commonRepo = new Common();
        }
        public ActionResult AnnexureIs()
        {
            return View();
        }
        public PartialViewResult _AllAnnexureI()
        {
            //ViewBag.AnnexureDetails = annexureIRepo.GetAllDetails();
            ViewBag.EmployeeList = employeeRepo.GetAll();
            var model = annexureIRepo.GetAll();
            return PartialView(model);
        }

        #region Details
        [Route("HRMS/Region/Details/{Id}/{IsView}")]
        public ActionResult Details(Guid Id, string IsView)
        {
            TempData["IsView"] = IsView;
            return RedirectToAction("Record", "Region", new { Id });
        }
        #endregion
        #region Record
        public ActionResult Record(Guid? Id)
        {
            ViewData["IsView"] = Convert.ToString(TempData["IsView"]);
            var model = new CPCAnnexureI();
            if (Id.HasValue)
            {
                model = annexureIRepo.GetById(Id.Value);
            }
            else
            {
                model.DateOfCollection = DateTime.Now;
                // model.SrNo = annexureIRepo.GetNextSrNo();
                //model.IsActive = true;
            }
            ViewBag.EmployeeList = new SelectList(employeeRepo.GetDropdown(), "Value", "Text");
            ViewBag.BrachList = new SelectList(branchRepo.GetDropdown(), "Value", "Text");
            ViewBag.DenominationList = new SelectList(commonRepo.GetAllDenominationDropdown(), "Value", "Text");
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Record(CPCAnnexureI model, List<CPCAnnexureIDetail> CPCAnnexureIDetail)
        {
            try
            {
                if (model.Id.IsEmpty())
                {
                    model.CreatedBy = CurrentUser.Id;
                    model.CreatedOn = DateTime.Now;
                    //model.IsActive = true;
                    model.Id = Guid.NewGuid();
                    var res = annexureIRepo.Create(model);
                    if (res.HasValue)
                    {
                        var lsToSave = CPCAnnexureIDetail.Where(x => !string.IsNullOrEmpty(x.CashProcessingCell) && x.NoOfBundles > 0).ToList();
                        lsToSave.ForEach(x => { x.Id = Guid.NewGuid(); x.AnnexureIId = model.Id; x.CreatedOn = DateTime.Now; x.CreatedBy = CurrentUser.Id; });
                        #region Save Details
                        annexureIRepo.Create(lsToSave);
                        #endregion

                        model.Id = res.Value;
                    }

                    #region Activity Log
                    //appLog.Create(CurrentUser.OfficeId, model.Id, CurrentUser.Id, AppLogType.Activity, "CRM - Lead", model.FullName + " lead created", "~/CRM/Contact/LeadRecord > HttpPost", "<table class='table table-hover table-striped table-condensed' style='margin-bottom:15px;'><tr><th class='text-center'>Description</th></tr><tr><td><strong>" + model.FullName + "</strong> lead created by <strong>" + CurrentUser.FullName + "</strong>.</td></tr></table>");
                    #endregion

                    #region EmailSending

                    //Emailer.Send(model.Email, EmailTemplateType.ContactSignup, model);

                    //var appMessageModel = new AppMessage();
                    //appMessageModel.Email = model.Email;
                    //appMessageModel.Status = AppMessageStatus.Outbox;
                    //appMessageModel.Subject = EmailTemplateType.ContactSignup;
                    //appMessageModel.Message = EmailTemplateType.ContactSignup;
                    //TempData["SuccessMsg"] = "Message has been sent successfully.";
                    //realtime.UpdateMessages(null);
                    //appMessageModel.CreatorId = appMessageModel.ContactId = CurrentUser.Id;
                    //appMessageModel.Id = appMsg.Create(appMessageModel);

                    ////var cntact = appUser.GetUserById(new Guid(x));
                    //appMsg.Create(null, appMessageModel.Id, appMessageModel.CreatorId, null, AppMessageStatus.Inbox, EmailTemplateType.ContactSignup, model.Id, null);

                    //realtime.UpdateMessages(null);
                    #endregion

                    TempData["SuccessMsg"] = model.SrNo + " has been created successfully.";
                }
                else
                {
                    model.UpdatedBy = CurrentUser.Id;
                    model.UpdatedOn = DateTime.Now;
                    bool res = annexureIRepo.Update(model);


                    if (res)
                    {
                        TempData["SuccessMsg"] = model.SrNo + " has been updated successfully.";
                    }
                    else
                    {
                        TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
                    }
                    #region Activity Log
                    //appLog.Create(CurrentUser.OfficeId, model.Id, CurrentUser.Id, AppLogType.Activity, "CRM - Lead", model.FullName + " lead updated", "~/CRM/Contact/LeadRecord > HttpPost", "<table class='table table-hover table-striped table-condensed' style='margin-bottom:15px;'><tr><th class='text-center'>Description</th></tr><tr><td><strong>" + model.FullName + "</strong> lead updated by <strong>" + CurrentUser.FullName + "</strong>.</td></tr></table>");
                    #endregion

                }
            }
            catch (Exception ex)
            {
                #region Error Log
                //appLog.Create(CurrentUser.OfficeId, null, CurrentUser.Id, AppLogType.Error, "CRM - Lead", ex.GetType().Name.ToSpacedTitleCase(), "~/CMS/FileManager/Index > HttpPost", "<table class='table table-hover table-striped'><tr><th class='text-right'>Source</th><td>" + ex.Source + "</td></tr><tr><th class='text-right'>URL</th><td>" + Request.Url.ToString() + "</td></tr><tr><th class='text-right'>Message</th><td>" + ex.Message + "</td></tr></table><table class='table table-hover table-striped table-condensed'><tr><th class='text-center'>Inner Exception</th></tr><tr><td>" + ex.InnerException + "</td></tr><tr><th class='text-center'>Stack Trace</th></tr><tr><td>" + ex.StackTrace.ToString() + "</td></tr></table>");
                #endregion

                TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
            }
            //if (SaveClick == "SaveAddNew")
            //{
            //    return RedirectToAction("Record");
            //}
            //else
            //{
            return RedirectToAction("AnnexureIs");
        }
        #endregion

        #region Remote Functions

        [HttpGet]
        public JsonResult GetAnnexureI(Guid Id, string date)
        {
            var ls = annexureIRepo.GetByDateBranchId(Id, Convert.ToDateTime(date));
            if (ls != null && ls.Count > 0)
            {
                return Json(new
                {
                    ShipmentReciptNo = ls.FirstOrDefault().ShipmentReciptNo,
                    SealNo = ls.FirstOrDefault().SealNo,
                    Id = ls.FirstOrDefault().Id,
                    details = ls.Select(x => new { x.DenominationId, x.DenominationTitle, }).OrderBy(x => x.DenominationTitle)
                }, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public JsonResult GetDesignationsByDepartId(Guid Id)
        //{
        //    return Json("");//designationRepo.GetDesignationDropdown(Id));
        //}
        #endregion

        #region Delete
        //[HttpPost]
        //public JsonResult Delete(Guid Id)
        //{
        //    try
        //    {
        //        #region Activity Log
        //        //appLog.Create(CurrentUser.OfficeId, Id, CurrentUser.Id, AppLogType.Activity, "CRM", "Contact Deleted", "~/CRM/Contact/Delete > HttpPost", "<table class='table table-hover table-striped table-condensed' style='margin-bottom:15px;'><tr><th class='text-center'>Description</th></tr><tr><td>Contact deleted by <strong>" + CurrentUser.FullName + "</strong>.</td></tr></table>");
        //        #endregion
        //        annexureIRepo.Delete(Id);

        //        TempData["SuccessMsg"] = "Department has been deleted successfully.";
        //    }
        //    catch (Exception ex)
        //    {
        //        #region Error Log
        //        //appLog.Create(CurrentUser.OfficeId, null, CurrentUser.Id, AppLogType.Error, "CRM", ex.GetType().Name.ToSpacedTitleCase(), "~/CRM/Contact/Delete > HttpPost", "<table class='table table-hover table-striped'><tr><th class='text-right'>Source</th><td>" + ex.Source + "</td></tr><tr><th class='text-right'>URL</th><td>" + Request.Url.ToString() + "</td></tr><tr><th class='text-right'>Message</th><td>" + ex.Message + "</td></tr></table><table class='table table-hover table-striped table-condensed'><tr><th class='text-center'>Inner Exception</th></tr><tr><td>" + ex.InnerException + "</td></tr><tr><th class='text-center'>Stack Trace</th></tr><tr><td>" + ex.StackTrace.ToString() + "</td></tr></table>");
        //        #endregion

        //        TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
        //    }
        //    return Json(true);
        //}

        //[HttpPost]
        //public JsonResult DeleteMultiple(string Ids)
        //{
        //    try
        //    {
        //        var idsList = Ids.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //        if (!string.IsNullOrEmpty(Ids))
        //        {
        //            var lsIds = new List<Guid>();
        //            foreach (var x in idsList)
        //            {
        //                lsIds.Add(new Guid(x));
        //            }
        //            annexureIRepo.DeleteMultiple(lsIds);
        //        }

        //        #region Activity Log
        //        //appLog.Create(CurrentUser.OfficeId, null, CurrentUser.Id, AppLogType.Activity, "CRM", "Multiple Contacts Deleted", "~/CRM/Contact/DeleteMultiple > HttpPost", "<table class='table table-hover table-striped table-condensed' style='margin-bottom:15px;'><tr><th class='text-center'>Description</th></tr><tr><td>Multiple contacts deleted by <strong>" + CurrentUser.FullName + "</strong>.</td></tr></table>");
        //        #endregion

        //        TempData["SuccessMsg"] = "Selected department has been deleted successfully.";
        //    }
        //    catch (Exception ex)
        //    {
        //        #region Error Log
        //        //appLog.Create(CurrentUser.OfficeId, null, CurrentUser.Id, AppLogType.Error, "CRM", ex.GetType().Name.ToSpacedTitleCase(), "~/CRM/Contact/DeleteMultiple > HttpPost", "<table class='table table-hover table-striped'><tr><th class='text-right'>Source</th><td>" + ex.Source + "</td></tr><tr><th class='text-right'>URL</th><td>" + Request.Url.ToString() + "</td></tr><tr><th class='text-right'>Message</th><td>" + ex.Message + "</td></tr></table><table class='table table-hover table-striped table-condensed'><tr><th class='text-center'>Inner Exception</th></tr><tr><td>" + ex.InnerException + "</td></tr><tr><th class='text-center'>Stack Trace</th></tr><tr><td>" + ex.StackTrace.ToString() + "</td></tr></table>");
        //        #endregion

        //        TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
        //    }
        //    return Json(true);
        //}
        #endregion


    }
}