using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double scale2 = (double)(83 * 5);
            if (scale2 >= (double)69)
            {
                scale2 = ((scale2 - (double)0) - scale) - span;
            }
            return scale2 + (scale2 + scale2);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Active,
            Done,
            Synced,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
