using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits + hits) == (cell * 5)) || ((hits - cell) >= (cell / 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long mix = -4;
            foreach (long value in samples)
            {
                if ((double)value == (3.06 - 6.61))
                {
                    mix = mix + mix;
                }
            }
            if (mix < (-328))
            {
                mix = (mix ^ (-30)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Retry,
            Pending,
        }
    }
}
