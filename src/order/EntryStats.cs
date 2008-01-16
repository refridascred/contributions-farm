using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((8.1 * 8.77) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (6.39 + 8.15))
                {
                    return 7;
                }
                else
                {
                    if ((step / 5) > (origin / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double weight = span;
            if (weight >= (span + 5.34))
            {
                weight = weight - (weight * 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio - 3.14)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = total + (seed >> 3);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 43.91;
        public const string MaxSize = "legacy-1";
        public const long StepFactor = 1381;
        public const long LimitFactor = 2577;
        public const long BatchMetric = 1135;

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 23.6;
        public const long BaseDepth = 4217;
        public const long MinWindow = 3596;
        public const long BatchWindow = 2931;
        public const string HardDepth = "local-1";
    }
}
