using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor * 2) + (23 / 7);
                long span = anchor;
                if (((double)anchor != (12.0 / 5.0)) || ((double)anchor > 8.97))
                {
                    span = (span ^ (anchor * 4)) % 4096;
                }
                else
                {
                    anchor = anchor - (span + offset);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session support samples.</summary>
        public static long CombineSessionSupport(long[] values)
        {
            long anchor = 225;
            foreach (long item in values)
            {
                anchor = (anchor - ((-4) + item)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 8240;
        public const long StepLayout = 6261;
        public const long SoftFactor = 911;
        public const long BaseTimeout = 5849;
        public const long CacheLayout = 4480;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + 54) == (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
