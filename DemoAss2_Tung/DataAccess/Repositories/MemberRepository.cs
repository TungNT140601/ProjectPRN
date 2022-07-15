using BussinessObject.Models;

namespace DataAccess.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public FStoreContext fStoreContext { get; set; }
        private Member _checkLogin(string email, string pass)
        {
            Member member = new Member();
            try
            {
                member = fStoreContext.Members.Where(mem => mem.Email == email && mem.Password == pass).FirstOrDefault();
                if (member == null)
                {
                    throw new Exception("Email or Password wrong!!!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return member;
        }
        private Member _getMemberById(int id)
        {
            Member member = new Member();
            try
            {
                member = fStoreContext.Members.Where(mem => mem.MemberId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Error get member by id");
            }
            return member;
        }
        private IEnumerable<Member> _getMemberList()
        {
            List<Member> listMem = new List<Member>();
            try
            {
                listMem = fStoreContext.Members.ToList();
            }
            catch
            {
                throw new Exception("Error get member list");
            }
            return listMem;
        }
        private void _addMember(Member member)
        {
            try
            {
                if (_checkMemberEmail(member.Email) == null)
                {
                    if (_checkMemberId(member.MemberId) == null)
                    {
                        fStoreContext.Members.Add(member);
                        fStoreContext.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This id has been used.");
                    }
                }
                else
                {
                    throw new Exception("This email has been used.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Member _checkMemberId(int id)
        {
            Member member = null;
            try
            {
                member = fStoreContext.Members.Where(mem => mem.MemberId == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        private Member _checkMemberEmail(string email)
        {
            Member member = null;
            try
            {
                member = fStoreContext.Members.Where(mem => mem.Email == email).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        private void _updateMember(Member member)
        {
            try
            {
                var m = fStoreContext.Members.Where(mem => mem.MemberId == member.MemberId).SingleOrDefault();
                m.MemberId = member.MemberId;
                m.Email = member.Email;
                m.City = member.City;
                m.Companyname = member.Companyname;
                m.Country = member.Country;
                m.Password = member.Password;
                fStoreContext.Entry<Member>(m).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                fStoreContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void _deleteMember(Member member)
        {
            try
            {
                var m = fStoreContext.Members.Where(mem => mem.MemberId == member.MemberId).SingleOrDefault();
                fStoreContext.Members.Remove(m);
                fStoreContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Member CheckLogin(string email, string pass)
        {
            return _checkLogin(email, pass);
        }
        public Member GetMemberByID(int id)
        {
            return _getMemberById(id);
        }
        public IEnumerable<Member> GetMemberList()
        {
            return _getMemberList();
        }
        public void AddMember(Member member)
        {
            _addMember(member);
        }
        public void UpdateMember(Member member)
        {
            _updateMember(member);
        }
        public void DeleteMember(Member member)
        {
            _deleteMember(member);
        }
        public Member CheckMemberEmail(string email)
        {
            return _checkMemberEmail(email);
        }
        public Member CheckMemberId(int id)
        {
            return _checkMemberId(id);
        }
    }
}
