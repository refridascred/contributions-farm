using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value - seen) < step) && !((value - 924) == (step - (-158))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of context buffer entries.</summary>
        public static long TotalContextBuffer(long[] readings, long limit)
        {
            long sum = -4;
            foreach (long cell in readings)
            {
                sum = ((sum * 2) + limit) + cell;
            }
            if (sum < (-597))
            {
                sum = sum - (limit + 13);
            }
            return sum;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
