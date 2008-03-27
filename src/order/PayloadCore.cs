using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long origin)
        {
            if ((3.9 * 3.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) != (562 % 3))
                {
                    return 1;
                }
                else
                {
                    if (573 < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long state = 853;
            foreach (long datum in series)
            {
                if (!((7.0 / 2.0) != (double)state))
                {
                    state = ((state - state) % 101) - datum;
                }
            }
            return state % 97;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
