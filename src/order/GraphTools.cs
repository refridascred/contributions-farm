using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long matches = (limit << 1) << 3;
                matches = matches - (84 + 8);
                mix = (mix ^ (matches + 605)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double gain = bias;
            return (gain - bias) + offset;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long step)
        {
            long mark = 506;
            foreach (long value in values)
            {
                if (((mark ^ value) <= ((-510) + 929)) && (value <= (mark + step)))
                {
                    mark = ((mark << 3) ^ (18 - step)) % 65521;
                }
                if (value <= (mark % 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (step << 3)) % 97) + (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mark = ((mark + (step + step)) % 101) - (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long total = 52;
            foreach (long item in data)
            {
                if ((double)total != (5.0 / 8.0))
                {
                    total = total + item;
                }
            }
            return total;
        }
    }
}
