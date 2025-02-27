namespace DzClassC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //square(5);

            //Console.WriteLine(isPalindrom(12321));

            //Site site = new Site();
            //site.Input("Google", "google.com", "Search", "198.0.0.1");
            //site.show();


            //site.setName("Google");
            //site.setUrl("google.com");
            //site.setOpis("Search");
            //site.setIp("198.0.0.1");
            //Console.WriteLine(site.getName());
            //Console.WriteLine(site.getURL());
            //Console.WriteLine(site.getOpis());
            //Console.WriteLine(site.getIp());


            //Book book = new Book();
            //book.Input("Book", 2021, "Opis", "123456789", "qaaa@gmaail.com");
            //book.Show();

            //Store store = new Store();
            //store.Input("Store", 123, "Opis", "123456789", "qaaa@gmaail.com");
            //store.Show();

            //Bowl bowl = new Bowl(100);
            //bowl.add(110);
            //bowl.take(20);
            //bowl.show();

            int[] a = { 1, 2, 6, 22, 88, 7, 6 };
            int[] b = { 6, 88, 7 };
            int[] res = filtArr(a, b);
            foreach (int it in res)
            {
                Console.WriteLine(it);
            }
        }

        static void square(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static bool isPalindrom(int num)
        {
            bool isPalindrom = false;
            string numStr = Convert.ToString(num);
            string revNum = "";
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                revNum += numStr[i];
            }
            if (numStr == revNum)
            {
                isPalindrom = true;
                return isPalindrom;
            }
            return isPalindrom;
        }

        static int[] filtArr(int[] orArr, int[] filArr)
        {
            int count = 0;
            int[] tempArr = new int[orArr.Length];

            for (int i = 0; i < orArr.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < filArr.Length; j++)
                {
                    if (orArr[i] == filArr[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    tempArr[count] = orArr[i];
                    count++;
                }
            }

            int[] res = new int[count];
            for (int i = 0; i < count; i++)
            {
                res[i] = tempArr[i];
            }

            return res;
        }
    }

    class Site 
    {
        private string name;
        private string url;
        private string opis;
        private string ip;

        public void setName(string str)
        {
            name = str;
        }
        public string getName()
        {
            return name;
        }

        public void setUrl(string str)
        {
            url = str;
        }
        public string getURL()
        {
            return url;
        }

        public void setOpis(string str)
        {
            opis = str;
        }
        public string getOpis()
        {
            return opis;
        }

        public void setIp(string str)
        {
            ip = str;
        }
        public string getIp()
        {
            return ip;
        }

        public void show()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("URL: " + url);
            Console.WriteLine("opis: " + opis);
            Console.WriteLine("IP: " + ip);
        }
        public void Input(string _name, string _url, string _opis, string _ip)
        {
            name = _name;
            url = _url;
            opis = _opis;
            ip = _ip;
        }
    }

    class Book
    {
        private string name;
        private int year;
        private string opis;
        private string phone;
        private string email;

        public void setName(string str) 
        {
            name = str;
        }
        public void setYear(int str)
        {
            year = str;
        }
        public void setOpis(string str)
        {
            opis = str;
        }
        public void setPhone(string str)
        {
            phone = str;
        }
        public void setEmail(string str)
        {
            email = str;
        }


        public string getName()
        {
            return name;
        }
        public int getYear() 
        { 
            return year; 
        }
        public string getOpis() 
        { 
            return opis; 
        }
        public string getPhone() 
        {
            return phone; 
        }
        public string getEmail() { 
            return email; 
        }

        public void Input(string _title, int _year, string _opis, string _phone, string _email)
        {
            name = _title;
            year = _year;
            opis = _opis;
            phone = _phone;
            email = _email;
        }

        public void Show()
        {
            Console.WriteLine("Naem: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Opis: " + opis);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }

    class Store
    {
        private string name;
        private int adress;
        private string opis;
        private string phone;
        private string email;

        public void setName(string str)
        {
            name = str;
        }
        public void setAdress(int str)
        {
            adress = str;
        }
        public void setOpis(string str)
        {
            opis = str;
        }
        public void setPhone(string str)
        {
            phone = str;
        }
        public void setEmail(string str)
        {
            email = str;
        }


        public string getName()
        {
            return name;
        }
        public int getAdress()
        {
            return adress;
        }
        public string getOpis()
        {
            return opis;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }

        public void Input(string _title, int _adress, string _opis, string _phone, string _email)
        {
            name = _title;
            adress = _adress;
            opis = _opis;
            phone = _phone;
            email = _email;
        }

        public void Show()
        {
            Console.WriteLine("Naem: " + name);
            Console.WriteLine("Adress: " + adress);
            Console.WriteLine("Opis: " + opis);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }

    class Bowl 
    {
        public string matereal;
        public int curV;
        public int maxV;
        public bool isFull;

        public Bowl(int V)
        {
            maxV = V;
            this.matereal = "iron";
            this.curV = 0;
            this.isFull = false;
        }

        public Bowl(int V, string mat)
        {
            maxV = V;
            this.matereal = mat;
            this.curV = 0;
            this.isFull = false;
        }

        public Bowl(int V, string mat, bool isFulll)
        {
            maxV = V;
            this.matereal = mat;
            this.curV = isFulll == true ? V : 0;
            this.isFull = isFulll;
        }

        public void add(int V)
        {
            if (curV + V <= maxV)
            {
                curV += V;
            }
            else
            {
                curV = maxV;
                Console.WriteLine("Ful and more");
            }
        }

        public void take(int V)
        {
            if (curV - V >= 0)
            {
                curV -= V;
            }
            else
            {
                curV = 0;
                Console.WriteLine("Empty and more");
            }
        }

        public void show()
        {
            Console.WriteLine("V: " + curV);
            Console.WriteLine("MaxV: " + maxV);
            Console.WriteLine("Matereal: " + matereal);
            Console.WriteLine("isFull: " + isFull);
        }
    }
}