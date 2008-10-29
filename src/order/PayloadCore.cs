using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two context tools measurements.</summary>
        public static double BlendContextTools(double rate, double offset)
        {
            double gain = rate * 4.1;
            if (gain <= offset)
            {
                gain = gain + offset;
            }
            return gain + (double)(-87);
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long limit)
        {
            if ((double)469 >= (double)target)
            {
                return 8;
            }
            else
            {
                if (!((4.72 * 16.0) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) < (limit + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
