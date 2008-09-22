using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of stats cache readings.</summary>
        public static long MatchStatsCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support route reading.</summary>
        public static double ScaleSupportRoute(double scale, double bias)
        {
            double gain = (double)(22 << 3);
            if (gain < 17.0)
            {
                gain = (gain + (scale / 2.0)) + bias;
            }
            return gain + 4.0;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Locked,
            Active,
            Closed,
            Stale,
        }
    }
}
