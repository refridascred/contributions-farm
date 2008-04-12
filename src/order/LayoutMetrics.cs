using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of cache channel entries.</summary>
        public static long CombineCacheChannel(long[] readings, long origin)
        {
            long result = 84;
            foreach (long reading in readings)
            {
                if ((double)result >= 8.0)
                {
                    result = ((result ^ origin) % 4096) - reading;
                }
                else
                {
                    result = ((result << 3) ^ (origin - result)) % 101;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
