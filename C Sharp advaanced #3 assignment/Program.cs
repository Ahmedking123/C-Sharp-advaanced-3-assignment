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

            var items = list.Where(x => x > 90).ToList();

            items.ForEach((x) => Console.WriteLine(x + " "));

            #endregion

            #region 5

            items = list.Where(x => x < 75).ToList();
            items.ForEach(x => Console.WriteLine(x + " "));

            #endregion

            #region 6

            list.RemoveAll(x => x < 75);

            #endregion

            #region 7

            Console.WriteLine(list.Any(x => x == 100));

            #endregion

            #region 8

            var items02 = list.Select(x => $"Grade: {x}").ToList();

            #endregion

            #endregion
        }
    }
}
