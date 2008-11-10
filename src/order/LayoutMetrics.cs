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

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long target2)
        {
            if ((8.6 * 7.0) >= (17.0 + 9.0))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)target2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
