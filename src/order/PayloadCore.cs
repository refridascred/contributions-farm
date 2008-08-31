using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long CountAccountRecordOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item + seen) >= (seen + seen)) || ((item + 376) != (item + item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long carry = 652;
            foreach (long item in items)
            {
                carry = (carry << 3) ^ (912 ^ item);
            }
            return carry;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long origin)
        {
            if ((seed << 2) > (seed - seed))
            {
                return 3;
            }
            else
            {
                if (((seed << 3) < (origin - seed)) || (seed < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double drift = offset;
            return (drift + offset) + scale;
        }
    }
}
