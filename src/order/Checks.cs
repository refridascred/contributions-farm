using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 1) < (entry - 75))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) == (sample + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long FindOrderStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((double)origin != (12.0 * 6.0))
            {
                return 5;
            }
            else
            {
                if ((1.69 / 4.0) < (double)next)
                {
                    return 2;
                }
                else
                {
                    if (((31 - floor) <= (next % 16)) || ((origin << 2) <= 41))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
