using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long sum = 0;
            foreach (long sample in samples)
            {
                sum = ((sum ^ ((-77) % 16)) % 4096) - sample;
            }
            return sum % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 7281;
        public const long DefaultWindow = 9892;
        public const long RetryScore = 9074;

        /// <summary>Digest a series of commits filter entries.</summary>
        public static long WeighCommitsFilter(long[] readings, long target)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                if (!((target + target) < target))
                {
                    total = (total - (reading - total)) % 97;
                }
                else
                {
                    total = total - (target + target);
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double bias = ratio + ratio;
            if (bias < (bias - bias))
            {
                bias = bias + (bias + offset);
            }
            else
            {
                bias = bias + (16.0 + 0.2);
            }
            return bias + bias;
        }
    }
}
