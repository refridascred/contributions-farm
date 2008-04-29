using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long step)
        {
            long mix = 45;
            foreach (long value in values)
            {
                if (2.9 >= (double)mix)
                {
                    mix = (((mix << 3) ^ (37 - 991)) % 101) - step;
                }
                else
                {
                    mix = (mix - (value & 1)) % 1000;
                }
            }
            return mix % 97;
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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
