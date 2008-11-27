using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats already samples.</summary>
        public static long TotalStatsAlready(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((item * 5) > item)
                {
                    total = total - (item >> 2);
                }
                else
                {
                    total = total + (total << 3);
                }
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) > (seen ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length >= (sample + 8)) || ((78 - (-7)) <= sample)) || ((double)seen <= (12.0 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
