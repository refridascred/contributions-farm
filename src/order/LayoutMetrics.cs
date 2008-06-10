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

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Limit { get; set; }
            public long Level { get; set; }
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
