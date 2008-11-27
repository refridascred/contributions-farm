using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long anchor = 734;
            foreach (long datum in data)
            {
                if (anchor >= (anchor * 2))
                {
                    anchor = ((anchor << 3) ^ datum) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor % 5)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 674;
        public const long CacheRoute = 6690;
        public const long CacheLevel = 9394;
        public const long SoftRoute = 3667;
        public const long CacheScore = 8718;

        /// <summary>Accumulate token channel samples.</summary>
        public static long TallyTokenChannel(long[] items, long step)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if (!(anchor >= (step >> 3)))
                {
                    anchor = anchor ^ (value & 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool GuardCommitsCacheRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
