using Assignment1.BusinessObject;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> memList = new List<MemberObject>()
        {
            new MemberObject(){MemberID = 1, MemberName = "John Smith", Email = "smithj@fstore.com", Password = "123456", City = "New York", Country = "USA" },
        new MemberObject(){MemberID = 2, MemberName = "Emma Johnson", Email = "johnsone@fstore.com", Password = "234567", City = "London", Country = "UK" },
        new MemberObject(){MemberID = 3, MemberName = "Carlos Rodriguez", Email = "rodriguezc@fstore.com", Password = "345678", City = "Madrid", Country = "Spain" },
        new MemberObject(){MemberID = 4, MemberName = "Anna Müller", Email = "mullera@fstore.com", Password = "456789", City = "Berlin", Country = "Germany" },
        new MemberObject(){MemberID = 5, MemberName = "Yuki Tanaka", Email = "tanakay@fstore.com", Password = "567890", City = "Tokyo", Country = "Japan" },
        new MemberObject(){MemberID = 6, MemberName = "Sophie Dupont", Email = "duponts@fstore.com", Password = "678901", City = "Paris", Country = "France" },
        new MemberObject(){MemberID = 7, MemberName = "Muhammad Ali", Email = "alim@fstore.com", Password = "789012", City = "Cairo", Country = "Egypt" },
        new MemberObject(){MemberID = 8, MemberName = "Ivan Petrov", Email = "petrovi@fstore.com", Password = "890123", City = "Moscow", Country = "Russia" },
        new MemberObject(){MemberID = 9, MemberName = "Chen Wei", Email = "weic@fstore.com", Password = "901234", City = "Beijing", Country = "China" },
        new MemberObject(){MemberID = 10, MemberName = "Luis Fernandez", Email = "fernandezl@fstore.com", Password = "012345", City = "Buenos Aires", Country = "Argentina" },
        new MemberObject(){MemberID = 11, MemberName = "Hiroshi Suzuki", Email = "suzukih@fstore.com", Password = "123450", City = "Osaka", Country = "Japan" },
        new MemberObject(){MemberID = 12, MemberName = "Isabella Rossi", Email = "rossii@fstore.com", Password = "234501", City = "Rome", Country = "Italy" },
        new MemberObject(){MemberID = 13, MemberName = "Abdul Rahman", Email = "rahmana@fstore.com", Password = "345012", City = "Riyadh", Country = "Saudi Arabia" },
        new MemberObject(){MemberID = 14, MemberName = "Elena Kowalski", Email = "kowalskie@fstore.com", Password = "450123", City = "Warsaw", Country = "Poland" },
        new MemberObject(){MemberID = 15, MemberName = "Juan Gonzalez", Email = "gonzalezj@fstore.com", Password = "501234", City = "Bogotá", Country = "Colombia" },
        new MemberObject(){MemberID = 16, MemberName = "Yukihiro Takahashi", Email = "takahashiy@fstore.com", Password = "012345", City = "Kyoto", Country = "Japan" },
        new MemberObject(){MemberID = 17, MemberName = "Maria Lopez", Email = "lopezm@fstore.com", Password = "123456", City = "Barcelona", Country = "Spain" },
        new MemberObject(){MemberID = 18, MemberName = "Olga Ivanova", Email = "ivanovao@fstore.com", Password = "234567", City = "Saint Petersburg", Country = "Russia" },
        new MemberObject(){MemberID = 19, MemberName = "Tran Nhat Minh", Email = "minhtn@fstore.com", Password = "123456", City = "Hanoi", Country = "Vietnam" },
        new MemberObject(){MemberID = 20, MemberName = "Ali Khan", Email = "khana@fstore.com", Password = "456789", City = "Karachi", Country = "Pakistan" },
        new MemberObject(){MemberID = 21, MemberName = "Sophia Papadopoulos", Email = "papadopouloss@fstore.com", Password = "567890", City = "Athens", Country = "Greece" },
        new MemberObject(){MemberID = 22, MemberName = "Kim Ji-Won", Email = "kimjw@fstore.com", Password = "678901", City = "Seoul", Country = "South Korea" },
        new MemberObject(){MemberID = 23, MemberName = "Alessio Ferrari", Email = "ferrararia@fstore.com", Password = "789012", City = "Milan", Country = "Italy" },
        new MemberObject(){MemberID = 24, MemberName = "Jose Rodrigues", Email = "rodriguesj@fstore.com", Password = "890123", City = "Lisbon", Country = "Portugal" },
        new MemberObject(){MemberID = 25, MemberName = "Nguyen Thi Hoa", Email = "hoant@fstore.com", Password = "901234", City = "Ho Chi Minh City", Country = "Vietnam" },
        new MemberObject(){MemberID = 26, MemberName = "Mehmet Yilmaz", Email = "yilmazm@fstore.com", Password = "012345", City = "Istanbul", Country = "Turkey" },
        new MemberObject(){MemberID = 27, MemberName = "Aisha Ahmed", Email = "ahmeda@fstore.com", Password = "123456", City = "Dubai", Country = "UAE" },
        new MemberObject(){MemberID = 28, MemberName = "Lukas Novak", Email = "novakl@fstore.com", Password = "234567", City = "Prague", Country = "Czech Republic" },
        new MemberObject(){MemberID = 29, MemberName = "Wang Li", Email = "liw@fstore.com", Password = "345678", City = "Shanghai", Country = "China" },
        new MemberObject(){MemberID = 30, MemberName = "Elena Lopez", Email = "lopeze@fstore.com", Password = "456789", City = "Barcelona", Country = "Spain" },
        new MemberObject(){MemberID = 31, MemberName = "Nguyen Van Minh", Email = "minhnv@fstore.com", Password = "567890", City = "Da Nang", Country = "Vietnam" },
        new MemberObject(){MemberID = 32, MemberName = "Luca Ferrari", Email = "ferraril@fstore.com", Password = "678901", City = "Rome", Country = "Italy" },
        new MemberObject(){MemberID = 33, MemberName = "Yuki Nakamura", Email = "nakamuray@fstore.com", Password = "789012", City = "Osaka", Country = "Japan" },
        new MemberObject(){MemberID = 34, MemberName = "Maria Fernandez", Email = "fernandezm@fstore.com", Password = "890123", City = "Madrid", Country = "Spain" },
        new MemberObject(){MemberID = 35, MemberName = "Kim Seo-Joon", Email = "kimsj@fstore.com", Password = "901234", City = "Seoul", Country = "South Korea" },
        new MemberObject(){MemberID = 36, MemberName = "Anastasia Papadopoulos", Email = "papadopoulosa@fstore.com", Password = "012345", City = "Athens", Country = "Greece" },
        new MemberObject(){MemberID = 37, MemberName = "Rahul Singh", Email = "singhr@fstore.com", Password = "123456", City = "Delhi", Country = "India" },
        new MemberObject(){MemberID = 38, MemberName = "Hana Kim", Email = "kimh@fstore.com", Password = "234567", City = "Seoul", Country = "South Korea" },
        new MemberObject(){MemberID = 39, MemberName = "Antonio Rossi", Email = "rossia@fstore.com", Password = "345678", City = "Milan", Country = "Italy" },
        new MemberObject(){MemberID = 40, MemberName = "Tran Van Quoc", Email = "quoctv@fstore.com", Password = "456789", City = "Ho Chi Minh City", Country = "Vietnam" },
        new MemberObject(){MemberID = 41, MemberName = "Cristina Gonzalez", Email = "gonzalezc@fstore.com", Password = "567890", City = "Barcelona", Country = "Spain" },
        new MemberObject(){MemberID = 42, MemberName = "Satoshi Suzuki", Email = "suzukis@fstore.com", Password = "678901", City = "Tokyo", Country = "Japan" },
        new MemberObject(){MemberID = 43, MemberName = "Julia Petrova", Email = "petrovaj@fstore.com", Password = "789012", City = "Moscow", Country = "Russia" },
        new MemberObject(){MemberID = 44, MemberName = "Nguyen Van Hieu", Email = "hieunv@fstore.com", Password = "890123", City = "Hanoi", Country = "Vietnam" },
        new MemberObject(){MemberID = 45, MemberName = "Ricardo Sanchez", Email = "sanchezr@fstore.com", Password = "901234", City = "Mexico City", Country = "Mexico" },
        new MemberObject(){MemberID = 46, MemberName = "Yuka Tanaka", Email = "tanakay@fstore.com", Password = "012345", City = "Osaka", Country = "Japan" },
        new MemberObject(){MemberID = 47, MemberName = "Luigi Ferrari", Email = "ferraril@fstore.com", Password = "123456", City = "Rome", Country = "Italy" },
        new MemberObject(){MemberID = 48, MemberName = "Fatima Ahmed", Email = "ahmedf@fstore.com", Password = "234567", City = "Cairo", Country = "Egypt" },
        new MemberObject(){MemberID = 49, MemberName = "Cheng Wei", Email = "weic@fstore.com", Password = "345678", City = "Shanghai", Country = "China" },
        new MemberObject(){MemberID = 50, MemberName = "Gabriel Rodriguez", Email = "rodriguezg@fstore.com", Password = "456789", City = "Buenos Aires", Country = "Argentina" },
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public List<MemberObject> GetMemberList => memList;
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }

        public MemberObject getMemberById(int mId)
        {
            MemberObject mem = memList.SingleOrDefault(mem => mem.MemberID == mId);
            return mem;
        }
        public List<MemberObject> getMembersByName(string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }
        public List<MemberObject> getMembersByCountry(string country, string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.Country.Contains(country)).Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }
        public List<MemberObject> getMembersByCity(string city, string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.City.Contains(city)).Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }

        public void Update(MemberObject mem)
        {
            MemberObject obj = getMemberById(mem.MemberID);
            if (obj != null)
            {
                int tmp = memList.IndexOf(obj);
                memList[tmp].MemberID = mem.MemberID;
                memList[tmp].MemberName = mem.MemberName;
                memList[tmp].Email = mem.Email;
                memList[tmp].City = mem.City;
                memList[tmp].Country = mem.Country;
                memList[tmp].Password = mem.Password;
            }
            else
            {
                throw new Exception("Member do not exists.");
            }
        }

        public void Delete(MemberObject mem) {
            MemberObject obj = getMemberById(mem.MemberID);
            if(obj != null)
            {
                memList.Remove(obj);
            }
            else
            {
                throw new Exception("Member do not exists.");
            }
        }

        public void AddNew(MemberObject mem)
        {
            int id = memList[memList.Count - 1].MemberID;
            mem.MemberID = id+1;
            memList.Add(mem);
        }
       public List<string> getCities(string country)
        {
            List<string> tmp = memList.Where(mem => mem.Country.Contains(country)).Select(mem => mem.City).Distinct().ToList();

            return tmp;
        }

        public List<string> getCities()
        {
            List<string> tmp = memList.OrderBy(mem => mem.Country).Select(mem => mem.City).Distinct().ToList();

            return tmp;
        }
        public List<string> getCountry()
        {
            List<string> tmp = memList.Select(mem => mem.Country).Distinct().ToList();

            return tmp;
        }

        public MemberObject checkValid(string mail,string pass)
        {
            MemberObject tmp = memList.SingleOrDefault(mem => mem.Email.Equals(mail));
            if(tmp != null)
            {
                return tmp;
            }
            return null;
        }

    }
}
