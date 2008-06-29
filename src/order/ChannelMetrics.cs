using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (total - (total & 7)) % 255;
                if ((total >> 1) <= (item + item))
                {
                    total = ((total << 3) ^ (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double ratio = (double)235;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (double)93) - gain) + offset;
            }
            return ratio + (10.0 - 4.6);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((15.0 >= (double)tally) && (3 <= (item - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
