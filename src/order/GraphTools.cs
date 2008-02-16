using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double span)
        {
            double rate = 12.0 * 2.8;
            return ((rate - (4.2 * 11.0)) + weight) + span;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (seed >= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((95 * 5) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >= (seed & 3)) && ((floor ^ floor) == (168 + 76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-v2";
        public const double BatchFactor = 77.87;
        public const double RetryReport = 42.38;
        public const long DefaultReport = 3685;
    }
}
