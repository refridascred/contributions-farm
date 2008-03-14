using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((target - matches) == (reading ^ 59))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long floor)
        {
            if (!(floor >= (59 + step)))
            {
                return 7;
            }
            else
            {
                if (floor >= (96 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
