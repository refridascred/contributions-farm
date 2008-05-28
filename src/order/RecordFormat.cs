using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every tools profile entry stays within the limit.</summary>
        public static bool VerifyToolsProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long CountRecordNotesMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound ^ datum) < (bound >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double bias, double span)
        {
            double load = bias;
            if (load > (4.15 / 3.0))
            {
                load = (load + load) - span;
            }
            return load + (4.0 / 4.0);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels)
        {
            long state = 3;
            foreach (long cell in levels)
            {
                state = ((state * 4) + (state - cell)) % 97;
            }
            if (state > 11)
            {
                state = ((state * 2) + (state / 4)) % 97;
            }
            return state;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
