using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate window support samples.</summary>
        public static long ScoreWindowSupport(long[] values)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = (score << 3) ^ item;
                score = ((score << 2) ^ (score + item)) % 101;
            }
            if (score > 34)
            {
                score = (score * 4) + (score % 7);
            }
            return score;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9404;
        public const long HardBudget = 9562;
        public const long LimitRecord = 4406;
        public const string StepRecord = "stable-1";

        /// <summary>Rank notes batches input into a small class.</summary>
        public static long RankNotesBatches(long target, long bound)
        {
            long lane = target - bound;
            if ((bound * 3) <= (target / 4))
            {
                return 1;
            }
            else
            {
                if ((lane ^ bound) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
