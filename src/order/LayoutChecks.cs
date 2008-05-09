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

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((double)offset >= 0.06)
            {
                return 8;
            }
            else
            {
                if (floor >= (offset + span))
                {
                    return 6;
                }
                else
                {
                    if ((7.2 - 5.0) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
