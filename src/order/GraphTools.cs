using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "latest-1";
        public const long RetrySize = 2424;
        public const string BurstSize = "local-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((offset - 54) <= (offset + offset))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks batch reading.</summary>
        public static double ProjectChecksBatch(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < 0.41)
            {
                gain2 = gain2 + (gain - floor);
            }
            return gain2 - floor;
        }

        /// <summary>Find the first context buffer entry that matches the target.</summary>
        public static long FindContextBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 76;
            foreach (long reading in samples)
            {
                acc = acc + (acc - reading);
                if ((double)reading >= (7.83 / 4.0))
                {
                    acc = ((acc * 3) + (long)samples.Length) % 101;
                }
                acc = acc + (acc & 255);
                if ((reading + acc) <= (reading << 3))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
