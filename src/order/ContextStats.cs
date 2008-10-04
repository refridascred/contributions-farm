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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ result) % 255;
                if (640 < (result << 2))
                {
                    result = ((result << 3) ^ (result + step)) % 255;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
