using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((9.6 - 8.4) <= (3.0 / 9.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (3 + state);
                if ((target << 1) < 76)
                {
                    state = ((state * 2) + (state - target)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long floor)
        {
            long result = 21;
            foreach (long datum in series)
            {
                if ((datum % 8) > (floor * 2))
                {
                    result = ((result << 3) ^ 36) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
