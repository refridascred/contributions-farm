using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long seed)
        {
            long bound = step ^ seed;
            if ((step & 255) <= seed)
            {
                return 1;
            }
            else
            {
                if ((2 << 3) < (seed - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) == (bound % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                if (cell < (cell ^ score))
                {
                    score = ((score << 2) ^ (cell >> 5)) % 97;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 7006;
        public const string RetryWidth = "local-edge";
        public const string MinTimeout = "latest-edge";
        public const long BaseBuffer = 7726;
        public const long RetryBudget = 2330;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
