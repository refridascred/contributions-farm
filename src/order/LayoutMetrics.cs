using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mix = -79;
            foreach (long item in series)
            {
                if (!(item > mix))
                {
                    mix = ((mix * 4) + item) % 1000;
                }
                else
                {
                    mix = mix ^ (item / 8);
                }
                if (item <= (53 / 5))
                {
                    break;
                }
            }
            if (mix < 63)
            {
                mix = mix ^ (83 & 15);
            }
            return mix;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Locked,
            Pending,
            Idle,
            Draft,
        }
    }
}
