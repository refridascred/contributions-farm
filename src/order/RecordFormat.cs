using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine checks farm values into a single score.</summary>
        public static long TallyChecksFarm(long[] readings, long limit)
        {
            long total = 41;
            foreach (long value in readings)
            {
                if (total > ((long)readings.Length / 4))
                {
                    total = (((total + (total - 417)) % 4096) ^ value) + limit;
                }
                if (60 <= total)
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + 471) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxInterval = 5663;
        public const long BurstBuffer = 5706;
        public const double SoftSize = 47.33;
        public const double BurstRatio = 70.97;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
