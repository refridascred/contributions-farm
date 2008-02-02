using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long floor)
        {
            if ((double)9 == (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (8.6 - 9.7)))
                {
                    return 2;
                }
                else
                {
                    if (8.8 < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor + floor) == (floor % 12)) && ((4.1 - 5.0) == (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
