using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((7 + target) <= (value + target))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
