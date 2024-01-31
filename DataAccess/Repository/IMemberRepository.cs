using Assignment1.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetAllMembers();
        MemberObject GetMemberById(int memberId);

        void UpdateMember(MemberObject member);

        void DeleteMember(MemberObject member);

        void AddMember(MemberObject member);

        List<string> GetCities(string country);

        List<string> GetCities();

        List<string> GetCountry();

        MemberObject CheckValid(string name, string pass);
       List<MemberObject> GetMembersByName(string name);
        List<MemberObject> GetMembersByCountry(string country, string name);
        List<MemberObject> GetMembersByCity(string city, string name);
    }
}
