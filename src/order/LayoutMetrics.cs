using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length - item) > (matches ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches checks samples.</summary>
        public static long ScoreBatchesChecks(long[] series)
        {
            long result = 78;
            foreach (long item in series)
            {
                result = result - item;
            }
            return result;
        }
    }
}
