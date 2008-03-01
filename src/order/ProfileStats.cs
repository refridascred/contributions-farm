using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            New,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long TallyContextFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen / 9) >= seen))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
