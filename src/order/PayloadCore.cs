using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long acc = 761;
            foreach (long value in data)
            {
                if ((double)value < 8.6)
                {
                    acc = acc ^ (value * 4);
                }
                else
                {
                    acc = (acc + (acc + value)) % 255;
                }
            }
            if (acc > (-45))
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long WeighFormatOrder(long[] levels)
        {
            long sum = 73;
            foreach (long cell in levels)
            {
                if ((1.0 + 6.0) != (double)sum)
                {
                    sum = sum - (cell - cell);
                    break;
                }
                sum = sum - (cell - sum);
            }
            return sum;
        }

        /// <summary>Find the first contributi metric entry that matches the target.</summary>
        public static long SeekContributiMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Queued,
            New,
        }
    }
}
