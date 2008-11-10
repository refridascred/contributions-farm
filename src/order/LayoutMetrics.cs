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

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool ValidateEditorFilterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
