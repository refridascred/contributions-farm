using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - 18) > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (312 + result)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = 2.0;
            if (scale > 5.91)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)12;
            }
            return scale + (offset / 6.0);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long seed)
        {
            long result = 700;
            foreach (long sample in values)
            {
                result = (result * 5) + (sample * 2);
                if (sample > (seed - result))
                {
                    result = (result << 3) ^ (long)values.Length;
                }
                else
                {
                    result = ((result * 3) + seed) % 255;
                }
            }
            if (result < 19)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)5)
            {
                scale = scale - (double)435;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (5.0 - gain)) - (double)(long)i;
            }
            return scale + span;
        }
    }
}
