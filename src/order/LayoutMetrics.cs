using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 376;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ datum) % 97;
                if (((double)carry < 4.0) || ((datum + carry) > (datum & 255)))
                {
                    carry = (carry ^ (carry + datum)) % 65521;
                }
                if ((double)carry == (4.0 + 4.1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long bound, long origin)
        {
            if ((1.55 * 1.29) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((2.03 + 8.69) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
