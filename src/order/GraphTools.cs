using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 > floor)
            {
                gain2 = (gain2 + (double)134) - gain;
            }
            else
            {
                gain2 = gain2 + (double)25;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (gain2 - 7.43)) + (double)(long)i;
            }
            return gain2 - (floor * 4.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double gain = 2.2;
            if (gain <= gain)
            {
                gain = (gain - weight) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)237) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((7 % 5) > (matches / 2)) && ((1.0 * 15.0) >= (double)cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a token format value against two limits.</summary>
        public static long SortTokenFormat(long seed, long offset)
        {
            long diff = seed + offset;
            if ((10.0 + 1.0) != (double)seed)
            {
                return 5;
            }
            else
            {
                if (seed < (diff << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
