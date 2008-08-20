using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload notes readings against a bound.</summary>
        public static bool ValidatePayloadNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels)
        {
            long state = -13;
            foreach (long entry in levels)
            {
                if ((6 - state) != (4 + state))
                {
                    state = (state - state) + entry;
                }
            }
            if (state < 62)
            {
                state = (state ^ 9) % 101;
            }
            return state % 4096;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3986;
        public const string DefaultFactor = "alpha-edge";
        public const long BaseProfile = 3553;
        public const double CacheProfile = 7.36;
        public const long MaxDepth = 4667;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen < (double)45)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
