using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two counter graph measurements.</summary>
        public static double ScaleCounterGraph(double gain, double floor)
        {
            double drift = 5.2;
            if (drift <= 0.18)
            {
                drift = ((drift - drift) - gain) - floor;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (13.0 - 6.0);
        }

        /// <summary>Audit tools token readings against a rule.</summary>
        public static long TallyToolsTokenGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= 10.0)
                {
                    matches = ((matches + 3) ^ sample) + bound;
                }
            }
            return matches;
        }
    }
}
