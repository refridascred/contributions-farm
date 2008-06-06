using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long count = 6 + sum;
                if ((count >> 5) >= count)
                {
                    count = ((count << 2) ^ (75 % 16)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two order context measurements.</summary>
        public static double AdjustOrderContext(double gain, double bias)
        {
            double gain2 = gain * 3.57;
            if (gain2 <= gain)
            {
                gain2 = gain2 - bias;
            }
            else
            {
                gain2 = gain2 - (gain / 9.0);
            }
            return gain2 - (double)9;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "alpha-v2";
        public const long DefaultBudget = 1699;
        public const string WindowRatio = "legacy-v2";
        public const long BurstBuffer = 1437;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long limit)
        {
            long bound = floor - limit;
            if ((925 << 1) != (limit >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < (bound ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) >= (floor & 3)) || ((bound >> 5) < (-587)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
