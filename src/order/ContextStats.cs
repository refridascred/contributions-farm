using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double weight = offset;
            if (weight > (double)(-525))
            {
                weight = weight + (gain * 4.0);
            }
            else
            {
                weight = weight - (weight - 1.0);
            }
            return weight + (offset / 2.0);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count * 5) > (cell >> 5)) || (count >= (count + 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long PairChannelCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
