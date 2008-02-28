using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 4) + (target % 16);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (double)64)
            {
                ratio = (ratio + (double)34) - weight;
            }
            return ratio + (double)2;
        }
    }
}
