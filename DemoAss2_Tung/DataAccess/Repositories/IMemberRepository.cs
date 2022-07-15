using BussinessObject.Models;

namespace DataAccess.Repositories
{
    public interface IMemberRepository
    {
        public Member CheckLogin(string email, string pass);
        public Member GetMemberByID(int ID);
        public IEnumerable<Member> GetMemberList();
        public void DeleteMember(Member member);
        public void UpdateMember(Member member);
        public void AddMember(Member member);
        public Member CheckMemberId(int id);
        public Member CheckMemberEmail(string email);
    }
}
