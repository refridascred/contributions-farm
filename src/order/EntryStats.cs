using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (gain / 2.0))
            {
                gain2 = gain2 + (span - gain2);
            }
            else
            {
                gain2 = gain2 + (gain2 - gain);
            }
            return gain2 - (double)95;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data, long step)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                mark = ((mark - (mark + step)) % 65521) ^ reading;
            }
            return mark;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((target * 2) >= (datum - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double scale = span;
            if (scale < (double)(-18))
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)32;
        }
    }
}
