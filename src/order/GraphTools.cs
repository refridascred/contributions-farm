using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long step)
        {
            if ((step << 3) < floor)
            {
                return 7;
            }
            else
            {
                if (((8.0 * 7.4) == (double)step) || ((double)floor < (5.49 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a channel token reading.</summary>
        public static double SmoothChannelToken(double gain, double bias)
        {
            double scale = (gain - bias) / 8.0;
            if (scale >= bias)
            {
                scale = scale - (bias * 2.88);
            }
            return scale + bias;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Done,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Queued,
            Failed,
        }
    }
}
