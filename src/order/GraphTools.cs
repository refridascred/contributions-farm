using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the already format entries that pass the check.</summary>
        public static long CountAlreadyFormatGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((limit - count) < 7)
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double bias)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = rate - (bias + bias);
            }
            return rate + bias;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (9 * 3);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor + (9 * 4)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool VerifyBufferGraphLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.2 + 7.34) > (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
