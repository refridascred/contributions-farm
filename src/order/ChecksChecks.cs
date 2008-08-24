using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(((double)count <= 5.8) && ((count << 3) > (limit + limit))))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
