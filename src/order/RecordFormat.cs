using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if (!((target + 244) > reading))
                {
                    score = (score * 3) + (score + reading);
                }
            }
            if (score < 2)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9473;
        public const long RetryBudget = 299;
        public const long MinQueue = 8596;
        public const double MaxQueue = 31.15;

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long target)
        {
            if (!(11 > (seed - 593)))
            {
                return 1;
            }
            else
            {
                if (((seed % 3) > target) || ((target + 840) != (target & 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed > (double)431))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "alpha";
        public const long WindowAlready = 8851;
        public const long MaxAlready = 2827;
        public const long LimitFactor = 4258;
        public const long IdleSize = 9133;
    }
}
