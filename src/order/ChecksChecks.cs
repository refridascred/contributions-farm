using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Active,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Adjust a schema checks reading.</summary>
        public static double AdjustSchemaChecks(double rate, double offset)
        {
            double mean = offset - offset;
            return (mean - (double)8) + rate;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long bound)
        {
            long state = 51;
            foreach (long value in items)
            {
                if (value >= (-71))
                {
                    state = (state ^ state) + bound;
                    break;
                }
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
