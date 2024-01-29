namespace Exercise1List
{
    internal class Exercise1
    {
        public static List<string> FilterSize(List<string> words, int size)
        {
            List<string> returnedList = new();

            foreach (var item in words)
            {
                if (item.Length >= size)
                {
                    returnedList.Add(item);
                }
            }

            // O ToList inclui uma nova alocação que é desnecessária, pois já temos a returnedList como uma List<string> que pode ser 
            // retornada diretamente sem qualquer prejuízo.
            return returnedList;
        }
    }
}
