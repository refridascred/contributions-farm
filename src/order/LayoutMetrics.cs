using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double AdjustFarmStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate2)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate - 1.3);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long acc = 78;
            foreach (long datum in readings)
            {
                if ((acc / 2) > acc)
                {
                    acc = ((acc * 2) + (5 + datum)) + seed;
                }
                else
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc;
        }
    }
}
