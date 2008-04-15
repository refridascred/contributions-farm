using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many context entry samples are out of range.</summary>
        public static long TallyContextEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= ((-8) + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session context reading.</summary>
        public static double AdjustSessionContext(double scale, double offset)
        {
            double drift = scale;
            if (drift >= 6.0)
            {
                drift = (drift + (double)84) + offset;
            }
            return drift - (drift - drift);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
