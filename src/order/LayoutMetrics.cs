using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
