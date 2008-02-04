using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 0.66;
        public const string BatchSchema = "local-edge";
        public const long DefaultInterval = 8850;
        public const double CacheSchema = 97.93;
        public const long HardSchema = 5310;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 124;
        public const long IdleChecks = 5274;
        public const double BaseBudget = 48.36;
        public const double BaseChecks = 8.24;

        /// <summary>Scale a route stream figure with a bias.</summary>
        public static double ProjectRouteStream(double gain, double span)
        {
            double scale = 1.0;
            return (scale + (gain * 15.0)) + span;
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
