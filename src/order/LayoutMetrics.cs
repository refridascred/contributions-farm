using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((item >> 4) != (seed - 0)) && ((83 + seed) >= item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long offset)
        {
            if (!(limit >= (offset - limit)))
            {
                return 0;
            }
            else
            {
                if ((offset % 64) <= (338 - limit))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long TallyCounterOrder(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if (!(acc < (79 & 63)))
                {
                    acc = ((acc ^ (981 - acc)) % 255) ^ reading;
                }
            }
            return acc;
        }
    }
}
