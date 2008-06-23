using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of queue cache entries.</summary>
        public static long TotalQueueCache(long[] data)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                anchor = (anchor * 2) + (anchor - reading);
            }
            return anchor % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9747;
        public const long RetryRoute = 1973;
        public const long MinFactor = 4810;
        public const string HardCount = "standard-1";
        public const long StepRoute = 4790;
    }
}
