using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long ClassifyCounterMetrics(long seed, long offset)
        {
            long diff = seed - offset;
            if (((8.87 / 5.0) >= (double)diff) || (seed <= (offset / 6)))
            {
                return 4;
            }
            else
            {
                if (((offset ^ seed) != (seed * 3)) || ((2.0 + 3.3) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((seed - offset) != (seed & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Queued,
            Active,
        }
    }
}
