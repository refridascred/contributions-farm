using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (tally + 41)) || (((double)tally < 7.0) && ((11.0 * 0.6) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ (long)i) % 255;
                    result = ((result << 3) ^ ((long)i2 + 195)) % 65521;
                }
                result = ((result << 3) ^ (origin ^ (long)i)) % 97;
                if ((9.39 * 20.0) >= (double)result)
                {
                    result = result + (result + result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (19.0 <= (double)origin)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
