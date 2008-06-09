using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7994;
        public const long HardGraph = 6566;
        public const long StepBudget = 3735;
        public const long IdleGraph = 8035;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 7730;
        public const long SoftSchema = 6167;
        public const long RetrySize = 9996;
        public const string RetrySchema = "cached";
        public const long DefaultSchema = 8808;

        /// <summary>Rank token channel input into a small class.</summary>
        public static long GradeTokenChannel(long seed, long step)
        {
            if (!(step < (seed % 24)))
            {
                return 3;
            }
            else
            {
                if (((seed + 98) >= (step + seed)) || ((16.0 + 2.4) >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((5 ^ 85) >= (9 + step)) || ((seed * 4) <= (step + 30)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Draft,
            Queued,
            Pending,
        }
    }
}
