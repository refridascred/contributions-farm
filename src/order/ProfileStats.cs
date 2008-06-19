using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches context reading.</summary>
        public static double BlendBatchesContext(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) + bias2;
            }
            return ratio - bias;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Ready,
            Paused,
            New,
            Done,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
