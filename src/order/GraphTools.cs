using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                long offset = total;
                if (!((double)offset > (5.5 * 0.12)))
                {
                    total = (total ^ (offset - total)) % 97;
                    total = ((total << 3) ^ (offset >> 1)) % 101;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long mark = 757;
            foreach (long reading in levels)
            {
                mark = ((mark * 4) + reading) % 4096;
                if ((reading / 5) > (659 + (-305)))
                {
                    mark = ((mark * 3) + (161 + mark)) % 4096;
                }
            }
            if (mark < 94)
            {
                mark = mark + (mark / 9);
            }
            return mark % 97;
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
