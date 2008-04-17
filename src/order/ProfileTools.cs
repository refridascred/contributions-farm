using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 8451;
        public const double StepInterval = 12.99;
        public const long MinSchema = 4117;
        public const double IdleWidth = 12.17;

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
