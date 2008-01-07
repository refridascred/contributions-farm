using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = 15.0 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 11.0)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Roll a record metric counter forward.</summary>
        public static long SeriesRecordMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine session commits values into a single score.</summary>
        public static long CombineSessionCommits(long[] values, long bound)
        {
            long result = 79;
            foreach (long cell in values)
            {
                if (6.42 > (double)result)
                {
                    result = (result * 5) + cell;
                }
            }
            if (result < 2)
            {
                result = (result + (bound - bound)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long result = 640;
            foreach (long reading in levels)
            {
                if ((double)result <= (double)22)
                {
                    result = ((result ^ (long)levels.Length) + reading) + target;
                }
            }
            if (result < 16)
            {
                result = result ^ (618 % 10);
            }
            return result;
        }
    }
}
