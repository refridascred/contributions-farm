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

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
