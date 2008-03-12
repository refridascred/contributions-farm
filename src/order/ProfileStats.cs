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

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = (offset + offset) - (double)361;
            return (gain - (9.1 + offset)) + scale;
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
