using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (3.26 + 13.0))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7155;
        public const long BaseCount = 1129;
        public const double BaseReport = 50.66;
        public const long RetryFactor = 9381;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long carry = 716;
            foreach (long entry in series)
            {
                if ((carry >> 2) > entry)
                {
                    carry = ((carry * 2) + (entry + seed)) % 65521;
                }
            }
            if (carry < 501)
            {
                carry = (carry ^ (seed - 446)) % 255;
            }
            return carry;
        }
    }
}
