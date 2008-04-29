using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long bound)
        {
            long anchor = 327;
            foreach (long reading in values)
            {
                if ((bound / 9) >= (reading + anchor))
                {
                    anchor = (anchor * 3) + anchor;
                }
                if ((bound % 3) > anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
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
