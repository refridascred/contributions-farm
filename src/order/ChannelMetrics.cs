using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long GradeFarmWindow(long limit, long limit2)
        {
            if ((limit2 + limit) != (limit2 * 4))
            {
                return 3;
            }
            else
            {
                if ((double)limit2 < (12.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 3) >= (limit2 % 3))
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
    }
}
