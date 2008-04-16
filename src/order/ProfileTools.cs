using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of buffer metric readings.</summary>
        public static long MatchBufferMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count * 2) < (offset + count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Failed,
            Queued,
            Active,
        }
    }
}
