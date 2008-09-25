using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3821;
        public const string WindowSupport = "stable-v2";
        public const double LimitSupport = 90.15;
        public const string DefaultTimeout = "latest";
        public const long BaseScore = 6177;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (9 ^ matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell % 97) != (hits << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
