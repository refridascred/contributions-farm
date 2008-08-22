using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double drift = (double)23 / 6.0;
            if (drift <= drift)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
