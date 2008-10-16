using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 5738;
        public const string IdleMetrics = "staging";
        public const long RetryRatio = 6100;

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long offset)
        {
            long gap = step ^ offset;
            if ((0 ^ gap) < (9 - 182))
            {
                return 1;
            }
            else
            {
                if ((offset >> 3) == (offset ^ 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((state + value) >= (value + state))
                {
                    state = ((state * 4) + (state + 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of layout record readings.</summary>
        public static long DigestLayoutRecord(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                state = ((state + (8 % 16)) % 4096) + item;
            }
            return state;
        }
    }
}
