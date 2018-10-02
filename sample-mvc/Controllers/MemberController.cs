using sample_mvc.Models;
using sample_mvc.Models.Request.Member;
using sample_mvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sample_mvc.Controllers
{
    public class MemberController : ApiController
    {
        private ResponseMessage responseMessage = new ResponseMessage();
        private readonly MemberSevices memberSevices = new MemberSevices();
        public ResponseMessage Get()
        {
            var data = memberSevices.GetAll();
            responseMessage.Success(data);
            return responseMessage;
        }

        // GET: api/Default/5
        public ResponseMessage Get(int id)
        {
            var data = memberSevices.GetById(id);
            if (data == null)
                responseMessage.Error();
            else
                responseMessage.Success(data);
            return responseMessage;
        }

        // POST: api/Default
        public ResponseMessage Post([FromBody] AddMember addMember)
        {

            if (addMember != null & ModelState.IsValid)
            {
                Member member = new Member
                {
                    Account = addMember.Account,
                    Description = addMember.Description,
                    Name = addMember.Name,
                    Password = addMember.Password
                };
                var data = memberSevices.Add(member);
                responseMessage.Success(data);
            }
            else
                responseMessage.Error();
            return responseMessage;

        }
        public ResponseMessage Put(int id, [FromBody] UpdateMember updateMember)
        {
            if (updateMember != null & ModelState.IsValid)
            {
                var data = memberSevices.GetById(id);
                if (data == null)
                    responseMessage.Error();
                else
                {
                    data.Description = updateMember.Description;
                    data.Name = updateMember.Name;
                    memberSevices.Update(data);
                }
            }
            else
                responseMessage.Error();

            return responseMessage;

        }

        public ResponseMessage Delete(int id)
        {
            if (!memberSevices.Delete(id))
                responseMessage.Error();
            return responseMessage;

        }
    }
}
