using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate record window readings against a bound.</summary>
        public static bool GuardRecordWindowLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long carry = 33;
            foreach (long value in items)
            {
                if (origin >= (carry / 2))
                {
                    carry = (((carry * 4) + (origin - 4)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (3.9 >= (double)cell)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
