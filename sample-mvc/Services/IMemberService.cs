using sample_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample_mvc.Services
{
    interface  IMemberService
    {
        Member Add(Member member);
        Member GetById(int Id);
        IEnumerable<Member> GetAll();
        bool Update(Member member);
        bool Delete(int Id);
    }
}