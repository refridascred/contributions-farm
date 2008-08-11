using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double rate = floor * 2.0;
            if (rate >= (gain * 4.8))
            {
                rate = rate - 13.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 5.0) + (double)(long)i;
            }
            return rate + (floor * 4.78);
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
