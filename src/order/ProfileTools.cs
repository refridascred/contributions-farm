using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) >= ((-830) + cell))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long mix = 87;
            foreach (long item in readings)
            {
                if ((mix + mix) == (item * 5))
                {
                    mix = (mix + (-84)) - seed;
                }
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry - tally) <= tally) && ((tally << 1) <= entry)) || ((entry + entry) <= 23))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
