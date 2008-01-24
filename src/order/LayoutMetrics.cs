using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long AuditFarmPayloadHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((54 <= (seen ^ sample)) || ((seen + 622) != (sample % 16))) && ((seen << 1) == (sample - 39)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long origin)
        {
            long mix = 182;
            foreach (long value in values)
            {
                mix = (mix - (value - mix)) % 255;
                if ((origin / 6) < (value % 24))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
