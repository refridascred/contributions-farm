using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long MeasureOrderChannelHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((7.1 / 8.0) >= (double)bound)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Pending,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const double SoftChecks = 85.36;
        public const double BurstSpan = 59.24;
    }
}
