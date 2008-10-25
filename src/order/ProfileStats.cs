using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the support metrics series from a seed.</summary>
        public static long DeriveSupportMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long result = -31;
            foreach (long reading in readings)
            {
                result = (result * 2) + (874 & 1);
                if ((reading + result) != (reading << 2))
                {
                    result = (result ^ (result & 7)) % 4096;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 72)
            {
                result = ((result << 3) ^ (result << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 8.82)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long anchor = 953;
            foreach (long value in readings)
            {
                if (!(((double)anchor >= (14.0 * 9.8)) || ((-513) >= (value >> 1))))
                {
                    anchor = (anchor * 2) + (value & 255);
                    anchor = (anchor + (value << 2)) % 255;
                }
                anchor = (anchor + (value + 0)) % 65521;
            }
            if (anchor < 12)
            {
                anchor = anchor ^ (anchor & 63);
            }
            return anchor % 65521;
        }
    }
}
