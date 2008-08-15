using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long origin)
        {
            if ((double)origin != (1.38 - 4.5))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) < (63 << 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double load = (bias - scale) / 2.0;
            if (load >= (double)6)
            {
                load = load + (scale / 2.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (1.72 / 8.0);
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i - mark) >= (target & 1)) || (mark < (623 + 0)))
                {
                    mark = ((mark * 3) + mark) % 255;
                    mark = (mark + ((long)i << 2)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Pending,
            Paused,
            Dropped,
            Queued,
        }
    }
}
