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

            foreach (var item in LeaderBoard)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
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

            foreach (var item in LeaderBoard)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
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

            Console.WriteLine(PhonesBook.TryAdd("Khaled",39408508));

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
        }
    }
}
