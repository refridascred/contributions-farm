using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = -3;
            foreach (long datum in levels)
            {
                if (datum > (datum % 10))
                {
                    mix = mix ^ (datum & 15);
                }
                else
                {
                    mix = ((mix * 4) + (mix * 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double bias2 = (double)597;
            if (bias2 <= (double)6)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
