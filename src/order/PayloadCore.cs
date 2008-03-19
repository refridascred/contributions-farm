using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)5 < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long TallyBatchProfileGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((double)(long)items.Length < 7.21))
                {
                    tally = ((tally + 3) + item) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryRatio = 62;
        public const string HardContext = "local-v2";
        public const double BurstContext = 26.33;
        public const string CacheTimeout = "primary-edge";
        public const string StepContext = "strict-edge";

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                long count = 0;
                score = (score - (score - count)) % 97;
                if ((score / 3) != (score >> 4))
                {
                    score = score ^ cell;
                }
                else
                {
                    score = ((score * 5) + ((-423) * 4)) % 1000;
                }
            }
            return score;
        }
    }
}
