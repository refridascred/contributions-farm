using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long step)
        {
            long step2 = origin + step;
            if (((step & 255) == (step % 3)) && ((double)step2 == (7.0 * 0.07)))
            {
                return 3;
            }
            else
            {
                if ((step / 7) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((step > (669 + step)) && ((step / 7) <= (366 >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((90 - step) > (origin & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor already entry stays within the limit.</summary>
        public static bool CheckEditorAlreadyLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen & 63) > (seen % 8)) && ((floor * 2) == (floor * 5)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
