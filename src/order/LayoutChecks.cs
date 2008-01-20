using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double offset)
        {
            double ratio = (double)758 / 3.0;
            if (ratio > ratio)
            {
                ratio = ((ratio + (double)1) - scale) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (double)(-9);
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long FoldCounterSchema(long[] levels, long offset)
        {
            long anchor = 24;
            foreach (long cell in levels)
            {
                if (((double)anchor != (8.0 * 19.0)) && (cell < (offset + cell)))
                {
                    anchor = ((anchor << 3) ^ (offset / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-edge";
        public const string RetryRatio = "cached-edge";
        public const long MaxCount = 3435;
        public const long RetryTimeout = 5258;
        public const long BaseSpan = 4976;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long state = 184;
            foreach (long reading in data)
            {
                if ((80 * 2) < (reading * 3))
                {
                    state = (state + (-9)) % 101;
                }
                state = (state ^ state) % 65521;
                state = ((state << 2) ^ (7 - reading)) % 97;
            }
            if (state < (-16))
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }
    }
}
