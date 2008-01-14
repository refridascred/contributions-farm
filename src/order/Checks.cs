using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double gain = (double)6 / 5.0;
            return ((gain + 4.25) + weight) + span;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)tally < 6.0) || ((tally - value) != (4 * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values, long floor)
        {
            long result = -90;
            foreach (long sample in values)
            {
                if ((floor < (sample - floor)) || ((double)floor < (14.0 / 4.0)))
                {
                    result = (result + sample) % 97;
                }
                result = (result << 2) ^ ((-575) - sample);
            }
            if (result < 12)
            {
                result = (result + (result & 7)) % 101;
            }
            return result;
        }
    }
}
