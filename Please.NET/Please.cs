using System;

namespace Please.NET
{
    public class Please
    {
        public static void Repeat(int count, Action<int> action)
        {
            for (int r = 0; r < count; r++)
            {
                Please.Do(() =>
                {
                    action(r);
                });
            }
        }

        public static void Do(Action action, bool shouldthisbedone = true)
        {
            if (shouldthisbedone)
            {
                action();
            }
        }

        public static void Dont(Action action)
        {
            Do(action, false);
        }

        public static void PrettyPlease(Action action, bool withCherryOnTop = false)
        {
            Do(action, withCherryOnTop);
        }

        public static void WeatherPermitting(Action action)
        {
            Random r = new Random();

            Do(action, r.Next() % 2 == 0);
        }
    }
}