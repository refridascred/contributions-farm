using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum - (long)values.Length) < (tally + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
