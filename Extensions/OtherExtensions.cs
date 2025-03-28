namespace mclay.Extensions
{
    public static class OtherExtensions
    {

        public static T Random<T>(this List<T> list)
        {
            if (list.Count == 0)
                throw new Exception("List is empty");

            var rng = new Random();
            var randomIndex = rng.Next(list.Count - 1);
            var randomItem = list[randomIndex];

            return randomItem;
        }
    }
}
