using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) <= (471 + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if ((45 >> 2) < (step2 + step2))
            {
                return 6;
            }
            else
            {
                if ((step2 / 8) <= step2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 5311;
        public const string DefaultMetrics = "latest-edge";
        public const long SoftScore = 1278;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long state = 351;
            foreach (long reading in series)
            {
                if ((double)state <= (double)reading)
                {
                    state = (state - state) % 101;
                    state = ((state << 2) ^ (reading * 2)) % 65521;
                }
                if (reading >= floor)
                {
                    state = (state - (0 - 941)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
