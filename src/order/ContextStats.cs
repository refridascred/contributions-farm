using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) != (count % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading < (double)(long)items.Length) && (((double)reading < (4.0 / 4.0)) && ((count - 894) >= reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
