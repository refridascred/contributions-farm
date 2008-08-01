using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((2.89 * 4.0) != (double)item) && ((item & 63) < (seen & 15)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((floor * 2) >= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Idle,
        }
    }
}
