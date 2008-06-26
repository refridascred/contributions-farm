using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((4.73 * 1.0) >= (double)seen)
                {
                    seen = ((seen + 1) + datum) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) <= (98 * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Pending,
            New,
            Idle,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Paused,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ datum) - offset;
                if ((sum % 3) <= (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
