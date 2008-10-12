using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (6.1 / 4.0))
                {
                    hits = ((hits + 2) ^ datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long floor)
        {
            if (((double)floor >= (double)bound) || ((bound + floor) < (bound - floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - bound) > 13)
                {
                    return 4;
                }
                else
                {
                    if (floor > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.97 - 2.48) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6900;
        public const string LimitDepth = "strict-v2";
        public const long MinBatches = 6717;
        public const long StepDepth = 4321;
        public const long StepBatches = 7088;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
