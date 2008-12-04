using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 363;
            foreach (long sample in samples)
            {
                anchor = anchor ^ (sample % 12);
                if ((sample >> 2) == (anchor - anchor))
                {
                    anchor = anchor ^ (anchor / 4);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "cached-edge";
        public const long WindowScore = 835;
        public const double BurstRatio = 29.02;
        public const double DefaultProfile = 71.1;
        public const long WindowProfile = 2238;
    }
}
