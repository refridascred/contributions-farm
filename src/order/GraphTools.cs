using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a support cluster sample.</summary>
        public static long LookupSupportClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double weight = (double)306;
            return ((weight + (5.9 - 1.8)) + scale) + span;
        }
    }
}
