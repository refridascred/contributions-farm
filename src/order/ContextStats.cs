using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches % 7) <= (matches ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double gain = ratio * 6.83;
            if (gain >= ratio)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - gain;
        }
    }
}
