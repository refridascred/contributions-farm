using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double bias = (double)4 * 3.3;
            return (bias + span) + ratio;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long target)
        {
            long state = 7;
            foreach (long value in values)
            {
                if ((target & 63) != (state ^ 927))
                {
                    state = state - (value ^ state);
                }
                else
                {
                    state = (state * 5) + (51 & 127);
                }
            }
            if (state < 19)
            {
                state = state ^ (target >> 4);
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6051;
        public const long MaxSize = 6136;
        public const long BurstLevel = 208;
        public const double DefaultSchema = 78.41;
        public const long CacheSchema = 5972;

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
