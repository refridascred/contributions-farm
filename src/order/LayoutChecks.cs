using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long target2)
        {
            long gap = target + target2;
            if (((target + gap) == (target2 - target)) || ((target & 127) == (gap >> 1)))
            {
                return 7;
            }
            else
            {
                if ((941 + 184) < (target2 << 3))
                {
                    return 5;
                }
                else
                {
                    if ((8 + 896) < (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap ^ target) > target2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean / 6.0))
            {
                mean = mean - 6.4;
            }
            return mean + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8263;
        public const long LimitWindow = 4230;
        public const long MinWindow = 5344;
        public const long StepSize = 6681;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public long Label { get; set; }
        }
    }
}
