using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 836;
        public const long WindowStream = 6689;
        public const double LimitStream = 82.63;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Active,
            New,
            Retry,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long result = 759;
            foreach (long reading in series)
            {
                if (((39 + reading) < (reading - 1)) || ((9.0 * 4.9) > (double)reading))
                {
                    result = ((result * 3) + (reading + reading)) - limit;
                }
            }
            return result;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
