using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3510;
        public const double StepBatches = 64.47;
        public const string CacheDepth = "staging";
        public const double BurstBatches = 98.62;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long target)
        {
            long total = 772;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (total * 5)) ^ item;
            }
            if (total < 746)
            {
                total = (total * 3) + (total + target);
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= 27)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long CountStreamFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value >= 18.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
