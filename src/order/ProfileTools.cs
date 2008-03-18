using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 3135;
        public const long HardSchema = 411;
        public const double MinFactor = 18.76;
        public const long MaxSchema = 9649;
        public const long IdleSchema = 4971;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > 32)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long seed)
        {
            if (61 <= (seed & 127))
            {
                return 5;
            }
            else
            {
                if ((6.11 * 6.8) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((9.55 / 8.0) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (((double)state != (8.3 * 4.9)) && ((state + state) != (datum + 36)))
                {
                    state = state + (state >> 3);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen + reading) <= (reading + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
