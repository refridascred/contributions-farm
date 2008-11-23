using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long origin)
        {
            long anchor = 602;
            foreach (long item in data)
            {
                if ((double)490 <= (double)origin)
                {
                    anchor = (anchor - (anchor & 7)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample >= (0.8 / 3.0)) && ((origin < (seen - sample)) && ((seen * 3) < (86 & 63))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Draft,
            Paused,
        }
    }
}
