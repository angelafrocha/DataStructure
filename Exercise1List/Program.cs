namespace Exercise1List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>{

              "Idiossincrasia",
              "Ambivalente",
              "Quimérica",
              "Perpendicular",
              "Efêmero",
              "Pletora",
              "Obnubilado",
              "Xilografia",
              "Quixote",
              "Inefável"
            };

            List<string> printList = Exercise1.FilterSize(input, 10);

            foreach (var item in printList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
