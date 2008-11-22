using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batches cluster value from a seed.</summary>
        public static long RollBatchesCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if (91 >= anchor)
                {
                    anchor = ((anchor << 2) ^ (step + (long)i)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = (double)987 - (double)9;
            return ((gain - (double)782) + rate) + offset;
        }
    }
}
