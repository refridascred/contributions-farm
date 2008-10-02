using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double bias = (double)(9 & 3);
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 2.5) + (double)(long)i) - scale;
            }
            return bias + (span / 8.0);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up schema route samples.</summary>
        public static long OverlapSchemaRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long floor)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if (((8.9 / 5.0) <= (double)mix) || ((datum * 2) > mix))
                {
                    mix = mix + (mix - 885);
                    mix = (mix ^ (floor % 8)) % 4096;
                    continue;
                }
                mix = mix ^ (datum - datum);
                if (((double)mix >= 4.4) && ((datum + datum) > mix))
                {
                    mix = ((mix * 5) + datum) % 65521;
                }
                else
                {
                    mix = (mix << 2) ^ floor;
                }
            }
            if (mix < 28)
            {
                mix = (mix << 2) ^ (mix + floor);
            }
            return mix;
        }
    }
}
