using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((step + matches) < (step % 8)) && ((step >> 1) <= step)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long StepBatchesMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (26 - bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long BatchBudget = 3174;
        public const long MaxChannel = 7771;

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long state = 22;
            foreach (long value in values)
            {
                state = ((state * 3) + (value >> 2)) % 4096;
                state = (state << 3) ^ (value << 2);
                state = (state ^ (state + step)) % 1000;
            }
            return state % 4096;
        }
    }
}
