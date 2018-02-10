using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    public class ReplaceTest
    {
        public void Test()
        {
            TestEffect();
        }

        public void TestEffect()
        {
            int count = 1000;
            DateTime sdate;
            TimeSpan ts;
            Console.ReadLine();
            string srcSource = "Franklin's life is full of charming stories which all young men should know -- how he sold books in Boston, and became the guest of kings in Europe; how he was made Major General Franklin, only to quit because, as he said, he was no soldier, and yet helped to organize the army that stood before the trained troops of England and Germany. This poor Boston boy, without a day's schooling1, became master of six languages and never stopped studying; this neglected apprentice2 conquered the lightning, made his name famous, received degrees and diplomas from many colleges, and became forever remembered as , General Franklin philosopher, scientist and political leader.";
            string keyWords = "General Franklin";
            string replacer = "<span style='color:yello'>"+"General Franklin"+ "</span>";
            sdate = DateTime.Now;
            string targetSource = string.Empty;
            for (int i = 0; i < count; i++)
            {
                srcSource = "i" + srcSource;
                targetSource = srcSource.Replace(keyWords, replacer);
            }
             
            ts = DateTime.Now - sdate;
            Console.WriteLine(targetSource);
            Console.WriteLine("Spent time : {0}", ts.TotalMilliseconds);
            Console.ReadLine();
        }

        public void TestEffect1()
        {
            int count = 1000;
            DateTime sdate;
            TimeSpan ts;
            Console.ReadLine();
            string srcSource = "Franklin's lifes is full of charming stories which all young men should know -- how he sold books in Boston, and became the guest of kings in Europe; how he was made Major General Franklin, only to quit because, as he said, he was no soldier, and yet helped to organize the army that stood before the trained troops of England and Germany. This poor Boston boy, without a day's schooling1, became master of six languages and never stopped studying; this neglected apprentice2 conquered the lightning, made his name famous, received degrees and diplomas from many colleges, and became forever remembered as , General Franklin philosopher, scientist and political leader.";
            string keyWords = "(general franklin)";
            Regex regex = new Regex(keyWords, RegexOptions.IgnoreCase); 
            
            string replacer = "<span style='color:yello'>$1</span>";
            sdate = DateTime.Now;
            string targetSource = string.Empty;
            for (int i = 0; i < count; i++)
            {
                srcSource = "i" + srcSource;
                targetSource = regex.Replace(srcSource, replacer);
            }

            ts = DateTime.Now - sdate;
            Console.WriteLine(targetSource);
            Console.WriteLine("Spent time : {0}", ts.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
