using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool ValidateLayoutStreamLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long AuditSupportContributiMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (seen - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double ratio = (offset / 4.0) + (double)22;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio + gain)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
