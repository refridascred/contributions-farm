using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long state = 514;
            foreach (long reading in samples)
            {
                state = ((state + state) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.9 / 3.0) != (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Pending,
            Idle,
            Done,
        }
    }
}
