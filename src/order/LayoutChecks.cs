using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 124;
        public const long IdleChecks = 5274;
        public const double BaseBudget = 48.36;
        public const double BaseChecks = 8.24;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((seen + reading) != (188 ^ seen)) && ((long)levels.Length != (seen - 42))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster order value against two limits.</summary>
        public static long BucketClusterOrder(long floor, long seed)
        {
            if ((seed - seed) <= (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if ((seed >> 5) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((-854) <= (seed * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed / 8) < (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
