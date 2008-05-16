using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 31.49;
        public const long CacheInterval = 2400;
        public const long MinSpan = 3904;
        public const double LimitPayload = 31.18;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mix = 59;
            foreach (long value in samples)
            {
                if ((mix - 988) < (mix % 2))
                {
                    mix = mix + (mix * 4);
                }
                mix = mix ^ value;
            }
            if (mix > 246)
            {
                mix = (mix ^ (85 - 640)) % 255;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ value) <= (tally / 9))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "standard-edge";
        public const long CacheNotes = 1490;
        public const string MinNotes = "staging-edge";
        public const string DefaultInterval = "staging";
    }
}
