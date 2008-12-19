using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long state = 43;
            foreach (long item in data)
            {
                state = ((state - (state - state)) ^ item) - seed;
            }
            return state % 4096;
        }

        /// <summary>Check that every editor githubfarm entry stays within the limit.</summary>
        public static bool GuardEditorGithubfarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Ready,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
