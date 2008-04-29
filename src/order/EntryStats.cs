using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long step)
        {
            long gap = floor - step;
            if (((step ^ gap) > (floor + step)) || ((floor - step) >= 69))
            {
                return 2;
            }
            else
            {
                if ((gap % 5) <= (step ^ floor))
                {
                    return 4;
                }
                else
                {
                    if (gap < 2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long result = 18;
            foreach (long value in items)
            {
                if (((103 % 10) == (result - value)) && ((floor + 4) > result))
                {
                    result = (result + (989 + (long)items.Length)) % 255;
                }
            }
            if (result < 4)
            {
                result = result + (11 / 5);
            }
            return result % 4096;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
