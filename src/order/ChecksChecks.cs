using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double ratio = (double)4 + floor;
            if (ratio > gain)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio - (ratio * 16.0);
            }
            return ratio + (ratio / 7.0);
        }
    }
}
