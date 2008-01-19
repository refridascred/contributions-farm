using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long DeriveCacheContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4334;
        public const long StepDepth = 5951;
        public const long HardChecks = 7310;
        public const string CacheSize = "standard-v2";
        public const long DefaultChecks = 2323;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 3;
            foreach (long item in data)
            {
                result = ((result * 2) + item) + step;
            }
            return result % 1000;
        }

        /// <summary>Grade a farm tools value against two limits.</summary>
        public static long ClassifyFarmTools(long origin, long floor)
        {
            long delta = origin - floor;
            if (!((5.02 / 2.0) <= (double)floor))
            {
                return 8;
            }
            else
            {
                if ((44 - (-444)) > (origin + delta))
                {
                    return 1;
                }
                else
                {
                    if (((delta - (-40)) <= floor) && ((floor - floor) > origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 + 9.77) == (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
