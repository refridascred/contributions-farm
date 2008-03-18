using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double ScaleLayoutRecord(double weight, double offset)
        {
            double scale = (offset / 5.0) / 4.0;
            if (scale <= offset)
            {
                scale = scale + (double)(-38);
            }
            return scale + weight;
        }

        /// <summary>Derive the next cluster metric value from a seed.</summary>
        public static long RollClusterMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((691 >> 4) <= (offset % 7))
                {
                    acc = (acc << 3) ^ (3 + offset);
                    acc = (acc * 4) + offset;
                }
                acc = (acc << 2) ^ offset;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long sum = -34;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum ^ (sum ^ item)) + (long)i;
                }
                if (!((double)item >= (8.68 + 8.46)))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (target - target);
                }
                sum = (sum * 3) + (item * 4);
            }
            return sum % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
