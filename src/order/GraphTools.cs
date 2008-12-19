using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long step)
        {
            long state = 1;
            foreach (long cell in values)
            {
                state = (state ^ ((long)values.Length >> 1)) % 1000;
                state = (state << 2) ^ (cell * 4);
                state = ((state << 2) ^ (state % 10)) % 4096;
            }
            if (state > 958)
            {
                state = ((state << 2) ^ step) % 1000;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (origin + 429)) % 101;
                if ((result - (long)i) < origin)
                {
                    result = (result << 2) ^ (8 >> 1);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
