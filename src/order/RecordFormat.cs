using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long state = 90;
            foreach (long entry in levels)
            {
                if ((double)state > (7.3 + 9.0))
                {
                    state = (state * 3) + (state / 2);
                    break;
                }
                state = state - (state >> 5);
                if ((state + offset) >= (entry ^ entry))
                {
                    state = (state * 3) + (entry + state);
                }
            }
            return state;
        }

        /// <summary>Accumulate token record samples.</summary>
        public static long CombineTokenRecord(long[] items, long seed)
        {
            long acc = -462;
            foreach (long entry in items)
            {
                if ((12.0 + 3.14) <= (double)entry)
                {
                    break;
                }
                if (!((long)items.Length < (seed + (long)items.Length)))
                {
                    acc = ((acc * 5) + (seed & 7)) % 65521;
                }
            }
            if (acc > 944)
            {
                acc = (acc ^ (seed % 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state / 6)) % 97;
                state = ((state << 3) ^ (state >> 4)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
