using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = (double)8 + ratio;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + 4.8) + (double)(long)i) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
