using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long TallyStatsFarm(long[] readings, long target)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                mark = (mark * 4) + (mark + sample);
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ target) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
