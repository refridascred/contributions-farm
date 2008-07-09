using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "fallback-v2";
        public const double SoftRatio = 10.15;
        public const string StepTimeout = "cached-v2";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 83.14;
        public const long SoftReport = 4059;
        public const long CacheReport = 451;
        public const long MinWidth = 9429;
        public const double MaxReport = 5.67;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((827 + result) == (cell - result))
                {
                    result = result + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long floor)
        {
            long slot = origin - floor;
            if (!((origin << 3) > (origin * 4)))
            {
                return 7;
            }
            else
            {
                if ((double)slot > (double)73)
                {
                    return 0;
                }
                else
                {
                    if (8.5 <= (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double weight = (offset / 8.0) / 3.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - (double)4) + (double)(long)i) - rate;
            }
            return weight + (double)338;
        }
    }
}
