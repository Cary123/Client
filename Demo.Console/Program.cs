using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<CertEntry> certs = new Collection<CertEntry>();
            certs.Add(new CertEntry("A", "B"));
            certs.Add(new CertEntry("B", "C"));
            certs.Add(new CertEntry("C", "D"));

            LinkedList<CertEntry> all = new LinkedList<CertEntry>();
            all.AddLast(certs[0]);
            for (int j = 0; j < certs.Count - 1; j++)
            {
                for (int i = 0; i < certs.Count; i++)
                {
                    if (all.Last.Value.Issuer == certs[i].Subject)
                    {
                        all.AddLast(certs[i]);
                    }
                    if (all.First.Value.Subject == certs[i].Issuer)
                    {
                        all.AddFirst(certs[i]);
                    }
                }
            }
            CertEntry final = all.First.Value;
        }
    }

    class CertEntry
    {
        public string Subject { get; set; }
        public string Issuer { get; set; }
        public CertEntry(string sub, string issuer)
        {
            this.Subject = sub;
            this.Issuer = issuer;
        }
    }
}
