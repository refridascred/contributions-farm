using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 63) < reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
