using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long floor)
        {
            long mix = 370;
            foreach (long reading in items)
            {
                mix = (mix - mix) ^ reading;
                mix = mix + (floor + 684);
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long origin)
        {
            long result = 19;
            foreach (long reading in data)
            {
                if (!((result - result) >= 43))
                {
                    result = ((result << 2) ^ origin) % 255;
                    result = (result + (reading & 3)) % 97;
                }
                if (((origin << 2) >= (8 * 5)) || (reading >= 59))
                {
                    result = (result << 3) ^ (origin << 2);
                }
            }
            if (result < 61)
            {
                result = (result * 5) + (origin / 4);
            }
            return result;
        }
    }
}
