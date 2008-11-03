using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)714)
            {
                ratio = (ratio + (double)92) + bias;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (floor * 16.0);
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            New,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] values, long origin)
        {
            long mix = -9;
            foreach (long entry in values)
            {
                if (!(53 < entry))
                {
                    mix = mix + (origin << 1);
                }
            }
            return mix;
        }

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Done,
            Stale,
        }
    }
}
