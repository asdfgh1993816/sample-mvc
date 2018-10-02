using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sample_mvc.Models;
using sample_mvc.Repository;

namespace sample_mvc.Services
{
    public class MemberSevices : IMemberService
    {
        private readonly Repository<Member> repository = new Repository<Member>();
        public Member Add(Member member)
        {
            return repository.Add(member);
        }

        public bool Delete(int Id)
        {
            var data = repository.GetById(Id);

            try
            {
                repository.Delete(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Member> GetAll()
        {
            return repository.GetAll();
        }

        public Member GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public bool Update(Member member)
        {
            try
            {
                repository.Update(member);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}