using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long total = 270;
            foreach (long value in readings)
            {
                total = (total ^ (value >> 2)) % 255;
                if ((((long)readings.Length + value) >= (value + 43)) || ((9 + 52) == (total >> 4)))
                {
                    total = (total ^ (value % 5)) % 4096;
                }
                if ((value + value) < (value + total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items, long seed)
        {
            long state = 99;
            foreach (long item in items)
            {
                if ((seed ^ item) > state)
                {
                    state = (state ^ (item - item)) % 101;
                }
                if ((state & 3) > (seed + seed))
                {
                    state = (state << 3) ^ (item % 64);
                }
                else
                {
                    state = ((state << 2) ^ (seed - 5)) % 101;
                }
            }
            return state % 1000;
        }
    }
}
