using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Failed,
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
