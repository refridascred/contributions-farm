using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank buffer queue input into a small class.</summary>
        public static long GradeBufferQueue(long offset, long offset2)
        {
            if (9.0 < (double)offset2)
            {
                return 8;
            }
            else
            {
                if ((offset2 + 290) >= offset2)
                {
                    return 4;
                }
                else
                {
                    if (4.9 < (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)66)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 5.3;
            }
            return gain - (offset * 6.0);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((bound << 3) >= (cell - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
