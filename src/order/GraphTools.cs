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

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = scale;
            if (gain < (7.31 * 18.0))
            {
                gain = gain - (scale * 9.88);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (floor / 7.0);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (gain / 5.0))
            {
                rate = rate + 8.0;
            }
            else
            {
                rate = rate + (double)(-69);
            }
            return rate + (rate * 10.0);
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
