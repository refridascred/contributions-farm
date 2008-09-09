using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stream payload counter forward.</summary>
        public static long SeriesStreamPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every checks editor entry stays within the limit.</summary>
        public static bool ValidateChecksEditorLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
