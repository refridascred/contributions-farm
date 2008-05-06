using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long carry = -3;
            foreach (long value in data)
            {
                if ((carry ^ carry) >= (carry + value))
                {
                    carry = ((carry << 2) ^ (carry ^ value)) % 65521;
                }
            }
            if (carry > 95)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 0.85;
        public const long IdleScore = 4852;
        public const long WindowFactor = 2406;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((3 + entry) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long MeasureAlreadyChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((8.5 + 4.66) >= (double)target))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                long lane = (score + seed) >> 4;
                if ((lane + (long)i) >= (score & 15))
                {
                    lane = (lane << 2) ^ 223;
                    lane = (lane << 3) ^ 9;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
