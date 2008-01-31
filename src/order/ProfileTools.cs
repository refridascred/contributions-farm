using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (long)series.Length) - cell;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long FoldMetricsLayout(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = (score * 5) + sample;
            }
            if (score < (-67))
            {
                score = (score - 1) % 1000;
            }
            return score;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double gain = scale;
            if (gain <= (double)4)
            {
                gain = (gain + 8.56) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (1.69 / 4.0);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 178;
            foreach (long sample in levels)
            {
                if (!((6.3 - 11.0) != (double)mark))
                {
                    break;
                }
                mark = (mark + mark) + sample;
            }
            if (mark < 5)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 65521;
        }
    }
}
