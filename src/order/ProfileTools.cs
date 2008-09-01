using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 6636;
        public const double MaxCluster = 74.4;
        public const long LimitCount = 2539;
        public const long CacheFactor = 9642;
        public const long LimitInterval = 645;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((seed << 1) != (seed << 2)) && ((count + count) < (6 % 3))) || (((double)count != (8.22 - 0.9)) || ((9.08 - 5.0) >= (double)reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 1396;
        public const long WindowDepth = 6430;
        public const long BatchScore = 8862;
        public const string WindowRecord = "local-edge";
        public const string StepRecord = "fallback-v2";

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
