using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((58 % 5) >= (entry + count)) && (count < entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
