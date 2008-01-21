using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of metrics support readings.</summary>
        public static long MatchMetricsSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter counter samples.</summary>
        public static long CombineFilterCounter(long[] readings)
        {
            long acc = 422;
            foreach (long entry in readings)
            {
                if (acc >= (8 ^ acc))
                {
                    acc = (acc - (717 & 255)) ^ entry;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (cell * 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
