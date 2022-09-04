namespace Q1
{
    internal class ArrayService
    {
        private string[] array;
        private int maxElementLength;


        /// <summary>
        /// Метод для получения нового массива с элементами не больше определнной длины
        /// </summary>
        /// <param name="array">Базовый массив</param>
        /// <param name="maxCharCount">Максимальное количество символов в элементе</param>
        /// <returns></returns>
        public string[] GetStrings(string[] array, int maxCharCount)
        {
            this.array = array;
            maxElementLength = maxCharCount;

            int count = GetElementsCount();
            return GenerateArray(count);
        }


        private string[] GenerateArray(int newArrayLength)
        {
            string[] newArray = new string [newArrayLength];
            int arrayLength = array.Length;
            while (arrayLength > 0)
            {
                arrayLength--;

                if (array[arrayLength].Length > 3) continue;

                newArrayLength--;
                newArray[newArrayLength] = array[arrayLength];
            }

            return newArray;
        }

        private int GetElementsCount()
        {
            int count = 0;
            foreach (var s in array)
            {
                if (s.Length <= maxElementLength)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
