using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long bound)
        {
            long acc = -3;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    acc = (acc * 2) + ((-803) & 127);
                }
                if ((12.0 - 8.3) == (double)item)
                {
                    acc = (acc ^ (bound / 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load + (double)92;
            }
            return load + (load - 1.02);
        }
    }
}
