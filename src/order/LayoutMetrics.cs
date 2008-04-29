using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + 24) <= ((long)items.Length ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long target)
        {
            if (target >= (400 % 64))
            {
                return 1;
            }
            else
            {
                if ((24 + target) != (target * 5))
                {
                    return 0;
                }
                else
                {
                    if (target > (step / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((43 / 6) != (seen + seen)) && ((double)seen <= (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
