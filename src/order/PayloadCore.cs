using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5.8 + 4.0) >= (double)count) && ((origin >= (count << 3)) && (cell >= 41)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double ratio = 3.7;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + gain;
            }
            return ratio - (double)678;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long floor)
        {
            long result = 2;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result ^ (long)i) % 1000) + floor;
                }
                if ((double)datum > (3.33 * 8.34))
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
        }
    }
}
