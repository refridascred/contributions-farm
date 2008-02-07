using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi route readings against a rule.</summary>
        public static long AuditContributiRouteHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long DeriveContextStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark - (mark << 3)) + (long)i2;
                    mark = (mark * 2) + (66 >> 2);
                }
                mark = (mark ^ ((long)i - (long)i)) % 97;
                if ((635 << 1) <= (27 + mark))
                {
                    mark = (mark + (long)i) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ (mark - mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate session counter readings against a bound.</summary>
        public static bool CheckSessionCounterLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
