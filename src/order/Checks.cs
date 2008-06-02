using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry ^ step) % 1000) + datum;
            }
            if (carry < 724)
            {
                carry = (carry << 2) ^ 367;
            }
            return carry;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Draft,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double scale = (5.9 * 6.6) * 3.33;
            if (scale >= (double)3)
            {
                scale = ((scale + (double)44) - ratio) + bias;
            }
            else
            {
                scale = scale + (double)(-479);
            }
            return scale + scale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry - offset) != (entry + offset)) || ((offset >= (5 - entry)) || ((matches + offset) < (entry % 100))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
