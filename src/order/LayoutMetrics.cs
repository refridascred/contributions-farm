using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double weight = (double)680 + (double)65;
            if (weight >= (6.6 + offset))
            {
                weight = (weight + (weight - 3.41)) - scale;
            }
            return weight + (3.43 * 6.9);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter support entries.</summary>
        public static long DigestCounterSupport(long[] readings, long offset)
        {
            long mix = 179;
            foreach (long entry in readings)
            {
                if ((entry % 97) > mix)
                {
                    continue;
                }
                mix = ((mix * 2) + entry) % 255;
            }
            if (mix < 117)
            {
                mix = mix ^ offset;
            }
            return mix;
        }
    }
}
