using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i + limit) > (anchor & 31)))
                {
                    anchor = anchor - anchor;
                }
                if ((96 << 2) > (limit ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + limit)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long next = bound + offset;
            if ((offset + bound) < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 18.0) == (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
