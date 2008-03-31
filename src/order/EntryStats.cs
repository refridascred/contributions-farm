using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric metrics samples are out of range.</summary>
        public static long CountMetricMetricsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (4.64 * 15.0))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)result < (2.68 + 16.0)))
                {
                    result = result ^ (result % 24);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Paused,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = state + (long)i;
                state = (state + (offset % 8)) % 255;
                if ((state >> 1) < (state + 3))
                {
                    state = (state + ((long)i + offset)) % 4096;
                    break;
                }
                else
                {
                    state = state - (offset + state);
                    state = (state + state) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
