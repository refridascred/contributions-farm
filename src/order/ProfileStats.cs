using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a window contributi pair into a bucket.</summary>
        public static long GradeWindowContributi(long limit, long floor)
        {
            long cur = limit - floor;
            if ((floor & 1) >= (limit >> 5))
            {
                return 4;
            }
            else
            {
                if (!((7 % 5) == (floor - 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((0 ^ cur) > (floor << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor % 100) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
