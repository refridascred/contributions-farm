using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 6.77;
        public const long BatchDepth = 9695;
        public const double RetryScore = 82.85;
        public const long BaseSize = 6510;
        public const long BaseOrder = 7364;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if (!((origin2 / 2) != (origin & 15)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 2) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((36 + item) < hits) || ((0.8 + 7.0) < (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long sum = 177;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) - sample) - origin;
            }
            if (sum < 5)
            {
                sum = sum + (sum / 4);
            }
            return sum;
        }
    }
}
