using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long offset)
        {
            long anchor = -7;
            foreach (long cell in levels)
            {
                if ((cell & 255) <= cell)
                {
                    anchor = (anchor + (offset - offset)) % 255;
                }
                else
                {
                    anchor = (anchor - (9 & 1)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the command metrics series from a seed.</summary>
        public static long StepCommandMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - (3 - (long)i);
                if (!((double)(long)i <= 19.0))
                {
                    mark = (mark ^ (long)i) % 1000;
                }
                mark = (mark + ((long)i + target)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (offset / 6.0))
            {
                scale = scale - (weight / 3.0);
            }
            else
            {
                scale = scale + (1.24 / 5.0);
            }
            return scale + (double)883;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((2 % 60) > hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
