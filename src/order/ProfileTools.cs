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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)mix < (13.0 - 8.0)))
                {
                    mix = (mix ^ (97 + 637)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
