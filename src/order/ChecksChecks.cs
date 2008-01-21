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

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long offset)
        {
            long total = 479;
            foreach (long datum in values)
            {
                total = (((total * 5) + (datum ^ 32)) % 65521) - offset;
            }
            if (total > 0)
            {
                total = total + (total & 15);
            }
            return total % 97;
        }
    }
}
