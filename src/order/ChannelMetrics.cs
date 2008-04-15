using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up queue editor samples.</summary>
        public static long PairQueueEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
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
