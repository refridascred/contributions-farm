using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double ratio = span;
            if (ratio < (double)(-47))
            {
                ratio = (ratio + 19.0) + gain;
            }
            return ratio - (double)117;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long state = -4;
            foreach (long entry in values)
            {
                if ((10.0 - 5.6) <= (double)entry)
                {
                    state = (state + state) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 95;
            foreach (long sample in values)
            {
                if ((148 * 3) <= (state + sample))
                {
                    state = state - (state >> 4);
                }
            }
            return state;
        }
    }
}
