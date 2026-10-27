using System.Collections.Concurrent;

namespace C_Sharp_advaanced__3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1

            #region 1

            List<int> list = [85, 92, 78, 95, 88, 70, 100, 65];

            #endregion

            #region 2

            list.ForEach((x) => Console.Write(x + new string(" ")));
            Console.WriteLine();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.First());
            Console.WriteLine(list.Last());

            #endregion

            #region 3

            list.Sort();
            list.ForEach((x) => Console.Write(x + new string(" ")));

            #endregion

            #region 4

            var Above90 = list.Where(x => x > 90).ToList();

            Above90.ForEach((x) => Console.WriteLine(x + " "));

            #endregion

            #region 5

            var Lower75 = list.Where(x => x < 75).ToList();
            Lower75.ForEach(x => Console.WriteLine(x + " "));

            #endregion

            #region 6

            list.RemoveAll(x => x < 75);

            #endregion

            #region 7

            Console.WriteLine(list.Any(x => x == 100));

            #endregion

            #region 8

            var TransfaredString = list.Select(x => $"Grade: {x}").ToList();

            #endregion

            #endregion



            #region #2

            #region 1

            SortedDictionary<string, int> LeaderBoard = new();
            //500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            LeaderBoard.Add("Ahmed", 500);
            LeaderBoard.Add("Sara", 200);
            LeaderBoard.Add("Ali", 800);
            LeaderBoard.Add("Mona", 350);

            #endregion

            #region 2

            foreach (var t3 in LeaderBoard)
            {
                Console.WriteLine($"{t3.Key} = {t3.Value}");
            }

            #endregion

            #region 3

            var FirstScore = LeaderBoard.First();

            Console.WriteLine(FirstScore.Key + " " + FirstScore.Value);

            #endregion

            #region 4

            Console.WriteLine(LeaderBoard.Any(x => x.Value == 500));

            #endregion

            #region 5

            var PlayerScore999 = LeaderBoard.FirstOrDefault(x => x.Value == 999);

            #endregion

            #region 6

            LeaderBoard.Remove("Sara");

            foreach (var t4 in LeaderBoard)
            {
                Console.WriteLine($"{t4.Key} = {t4.Value}");
            }

            #endregion

            #endregion

            #region #3

            #region 1


            Dictionary<string, int> PhonesBook = new() { { "Ahmed", 293942 }, { "Mohamed", 3490234 } };

            #endregion

            #region 2

            PhonesBook["Ahmed"] = 0001100;
            PhonesBook["Mohamed"] = 3820123;
            PhonesBook["Ali"] = 1948192;
            PhonesBook["Mostafa"] = 3480302;

            #endregion

            #region 3

            try
            {
                PhonesBook.Add("Ahmed", 8524932);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            #region 4

            Console.WriteLine(PhonesBook.TryAdd("Khaled", 39408508));

            #endregion

            #region 5

            PhonesBook.TryGetValue("Wagdy", out var item);

            if (item != default)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 6

            if (!PhonesBook.ContainsKey("Abdo")) ;
            {
                Console.WriteLine("Not found");
            }

            #endregion

            #region 7

            foreach (var t in PhonesBook.Keys)
            {
                Console.Write(t + " ");
            }

            foreach (var t2 in PhonesBook.Values)
            {
                Console.Write(t2 + " ");
            }

            #endregion

            #endregion

            #region #4

            #region 1

            HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            #endregion

            #region 2

            // "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            Emails.Add("ahmed@test.com");
            Emails.Add("AHMED@test.com");
            Emails.Add("sara@test.com");
            Emails.Add("Sara@Test.Com");

            #endregion

            #region 3

            Console.WriteLine(Emails.Count);
            //Only 2 values since HasSet only adds unique values

            #endregion

            #region 4

            HashSet<int> A = [1, 2, 3, 4, 5];
            HashSet<int> B = [4, 5, 6, 7, 8];

            #endregion

            #region 5

            HashSet<int> Union = new(A);
            Union.UnionWith(B);

            HashSet<int> Intersect = new(A);
            Intersect.IntersectWith(B);

            HashSet<int> Except = new(A);
            Except.ExceptWith(B);

            foreach (var itemUnion in Union)
            {
                Console.WriteLine(itemUnion);
            }

            foreach (var ItemIntersect in Intersect)
            {
                Console.WriteLine(ItemIntersect);
            }

            foreach (var ItemExcept in Except)
            {
                Console.WriteLine(ItemExcept);
            }

            #endregion

            #region 6

            HashSet<int> hasSet = [1, 2];

            Console.WriteLine(hasSet.IsSubsetOf(A));

            #endregion

            #endregion

            #region #5

            Queue<string> queue = new();

            //"Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"
            queue.Enqueue("Report.pdf");
            queue.Enqueue("Invoice.pdf");
            queue.Enqueue("Letter.docx");
            queue.Enqueue("Resume.pdf");
            queue.Enqueue("Photo.jpg");

            #region 1

            Console.WriteLine(queue.Count);

            foreach( var QueueItem in queue)
            {
                Console.WriteLine(QueueItem);
            }

            #endregion

            #region 2

            Console.WriteLine(queue.Peek());

            #endregion

            #region 3

            while (queue.Count > 0)
            {
                Console.WriteLine($"Printing: [{queue.Dequeue()}]");
            }

            #endregion

            #region 4

            queue.TryDequeue(out string? dequeue);

            Console.WriteLine(dequeue);

            //it will output an empty item

            #endregion

            #endregion
        }
    }
}
