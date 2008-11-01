using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Project the next layout already value.</summary>
        public static double SmoothLayoutAlready(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)825)
            {
                ratio2 = (ratio2 + (double)941) + offset;
            }
            return ratio2 + (ratio / 8.0);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 3) + (mix / 3)) ^ (long)i2;
                }
                mix = (mix ^ ((long)i % 97)) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double gain = 6.0 / 3.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain + 7.0) + (double)(long)i) + ratio) - span;
            }
            return gain - (8.19 * 0.04);
        }
    }
}
