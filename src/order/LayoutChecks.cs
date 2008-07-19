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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long state = 919;
            foreach (long sample in levels)
            {
                state = state - step;
                state = (state - (sample + sample)) % 65521;
                if ((state % 12) <= step)
                {
                    break;
                }
            }
            return state;
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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = score + (score >> 4);
                score = (score ^ (target >> 5)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
