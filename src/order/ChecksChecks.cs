using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 64) == (seen - datum)) && (datum > (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = (total + (offset & 3)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long limit)
        {
            if (((double)limit >= (5.0 + 8.0)) || (limit >= 542))
            {
                return 7;
            }
            else
            {
                if (!((limit >> 2) >= (limit - 93)))
                {
                    return 1;
                }
                else
                {
                    if (((step * 4) > (limit + limit)) || ((step & 1) > (limit + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
