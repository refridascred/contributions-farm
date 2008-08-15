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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)step <= (13.0 - 4.1))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
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
