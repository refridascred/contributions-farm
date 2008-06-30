using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen > (datum / 5)) || ((double)seen < 0.7))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long total = 94;
            foreach (long reading in items)
            {
                total = ((total << 2) ^ (reading + 27)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed >= delta)
            {
                return 5;
            }
            else
            {
                if (seed > (delta - bound))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 160) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
