using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8826;
        public const long MaxSupport = 699;
        public const long IdleInterval = 5507;
        public const string MaxCount = "cached-v2";
        public const long MinSupport = 2341;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine editor notes values into a single score.</summary>
        public static long FoldEditorNotes(long[] levels)
        {
            long sum = 4;
            foreach (long cell in levels)
            {
                if ((sum - sum) <= (cell - sum))
                {
                    sum = (sum * 5) + (sum - sum);
                }
                else
                {
                    sum = sum - (sum << 1);
                }
                if ((double)sum < (17.0 + 8.9))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
