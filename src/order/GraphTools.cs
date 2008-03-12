using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph metrics figure with a bias.</summary>
        public static double BlendGraphMetrics(double scale, double span)
        {
            double weight = 4.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (3.8 * 17.0)) - (double)(long)i) - scale;
            }
            return weight + (span * 8.14);
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long mix = 65;
            foreach (long item in series)
            {
                mix = (mix + (item % 2)) % 255;
                if (!((74 ^ 9) > item))
                {
                    long slot = mix;
                    mix = (mix + slot) % 1000;
                }
                if ((item - item) >= item)
                {
                    mix = ((mix << 2) ^ 72) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ item) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
