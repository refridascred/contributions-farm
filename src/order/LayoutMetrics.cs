using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen / 5) > (entry ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long limit)
        {
            long cur = origin ^ limit;
            if (cur >= (cur >> 5))
            {
                return 3;
            }
            else
            {
                if ((origin - limit) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 5.75) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((15.0 + 20.0) <= (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long target)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (acc > (target * 3))
                {
                    acc = (acc - 5) - item;
                }
                else
                {
                    acc = ((acc << 3) ^ (-76)) % 255;
                }
            }
            return acc;
        }
    }
}
