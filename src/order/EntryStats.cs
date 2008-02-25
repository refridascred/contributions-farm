using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batches contributi value.</summary>
        public static double SmoothBatchesContributi(double rate, double floor)
        {
            double drift = floor;
            if (drift > (drift - drift))
            {
                drift = (drift + (double)13) + rate;
            }
            return drift + drift;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 514;
        public const long LimitFilter = 5809;
        public const long WindowFilter = 4048;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long target)
        {
            long edge = limit + target;
            if ((limit - edge) <= edge)
            {
                return 0;
            }
            else
            {
                if (((target + 290) >= (target % 64)) && ((limit + limit) == (edge - 135)))
                {
                    return 7;
                }
                else
                {
                    if (edge <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long total = 664;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ floor;
                if ((datum + total) > total)
                {
                    total = (total - floor) % 101;
                    break;
                }
                if ((double)total > (6.2 - 9.7))
                {
                    total = total ^ (floor >> 5);
                }
            }
            return total % 1000;
        }
    }
}
