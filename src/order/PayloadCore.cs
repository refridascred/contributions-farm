using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine tools record values into a single score.</summary>
        public static long TallyToolsRecord(long[] data, long seed)
        {
            long state = 768;
            foreach (long reading in data)
            {
                state = ((state * 4) + (state * 2)) % 97;
                if (((double)73 < (0.01 / 2.0)) || ((seed & 7) < (reading + state)))
                {
                    break;
                }
            }
            return state;
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
