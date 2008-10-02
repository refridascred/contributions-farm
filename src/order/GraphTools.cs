using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - 6) > (5 & 15))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long TallyOrderEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits > (hits / 8))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            if ((floor & 127) > (floor / 2))
            {
                return 4;
            }
            else
            {
                if (4 < (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if (!(floor < (floor - floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
