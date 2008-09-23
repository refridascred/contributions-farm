using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)limit > (13.0 * 9.2)) && ((89 << 2) <= (item & 127)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm editor sample.</summary>
        public static long LookupFarmEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((0.25 + 1.2) > (double)acc)
                {
                    acc = (acc + (162 + (long)i)) % 4096;
                }
                acc = acc + (0 + floor);
                acc = (acc * 4) + (56 ^ (long)i);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Closed,
            Idle,
            Queued,
            Paused,
        }
    }
}
