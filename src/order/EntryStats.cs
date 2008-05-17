using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a route graph figure with a bias.</summary>
        public static double AdjustRouteGraph(double scale, double floor)
        {
            double gain = (2.13 + 3.4) / 5.0;
            if (gain < (double)928)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale + floor)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 76;
            foreach (long entry in items)
            {
                sum = ((sum + sum) % 97) ^ entry;
            }
            if (sum > (-1))
            {
                sum = ((sum << 2) ^ 34) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7845;
        public const long RetryFormat = 7204;
        public const long IdleTimeout = 5288;
        public const string WindowSize = "open";
        public const long DefaultWidth = 6703;
    }
}
