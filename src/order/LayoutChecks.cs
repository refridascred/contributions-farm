using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 71.7;
        public const string IdleAlready = "alpha";
        public const long SoftAlready = 1703;
        public const string DefaultFactor = "open-edge";

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Queued,
            Ready,
            Active,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long origin)
        {
            long carry = 76;
            foreach (long reading in items)
            {
                if (((22 & 15) >= (carry + origin)) && ((double)origin >= 3.14))
                {
                    carry = (carry ^ (65 * 3)) - reading;
                }
            }
            return carry;
        }

        /// <summary>Match up counter entry samples.</summary>
        public static long OverlapCounterEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
