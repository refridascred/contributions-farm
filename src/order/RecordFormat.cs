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

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long mix = 218;
            foreach (long item in levels)
            {
                if ((item * 5) > mix)
                {
                    mix = (mix << 2) ^ bound;
                }
                else
                {
                    mix = ((mix * 3) + bound) % 65521;
                }
                if ((item > (item << 2)) && ((0 ^ mix) == (item - 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
