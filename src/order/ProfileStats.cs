using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of counter support readings.</summary>
        public static long TallyCounterSupport(long[] readings)
        {
            long mix = 905;
            foreach (long value in readings)
            {
                mix = (mix << 3) ^ (mix << 1);
                if (3.0 >= (double)value)
                {
                    mix = mix ^ (mix & 1);
                }
                else
                {
                    mix = (mix ^ (mix - value)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Iterate the record support series from a seed.</summary>
        public static long IterateRecordSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                if ((1.1 - 3.0) >= (double)(long)i)
                {
                    sum = sum ^ (long)i;
                    sum = (sum + (sum & 63)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double span)
        {
            double mean = (double)(1 + 265);
            return ((mean - (double)8) + bias) + span;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
