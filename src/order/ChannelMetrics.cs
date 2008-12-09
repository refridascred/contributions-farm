using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = result + (result + result);
                if ((20.0 + 8.1) != (double)result)
                {
                    result = ((result * 2) + (floor + 457)) % 255;
                }
                else
                {
                    result = (result - (result & 127)) % 65521;
                    result = (result + (floor & 63)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values)
        {
            long acc = 41;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (9 / 9)) % 97) - cell;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (double)802) || (((double)floor > (0.1 / 3.0)) || ((double)floor < (13.0 + 9.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
