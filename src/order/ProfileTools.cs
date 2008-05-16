using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long seed)
        {
            if (((origin - origin) <= seed) && ((9.1 - 9.9) >= (double)seed))
            {
                return 6;
            }
            else
            {
                if ((5 - seed) >= (seed & 1))
                {
                    return 2;
                }
                else
                {
                    if ((24 * 4) >= (seed % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((6.05 / 9.0) == (double)seed)
                {
                    sum = (sum * 5) + 494;
                }
                sum = (sum + ((long)i + 1)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((1.92 / 4.0) == (double)tally) || ((sample - tally) < (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels)
        {
            long result = 984;
            foreach (long item in levels)
            {
                if ((item - item) >= (result << 1))
                {
                    result = result ^ (557 >> 5);
                }
                else
                {
                    result = ((result << 2) ^ item) % 97;
                }
            }
            if (result < 67)
            {
                result = (result * 5) + result;
            }
            return result;
        }
    }
}
