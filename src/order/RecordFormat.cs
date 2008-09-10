using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane * 4) <= (lane % 7))
            {
                return 2;
            }
            else
            {
                if (!((target ^ lane) < (bound - lane)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (8.2 - 1.39))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane << 2) <= (lane + lane))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
