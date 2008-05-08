using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((origin % 5) >= (366 >> 2)) && (seen >= (item >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first report window entry that matches the target.</summary>
        public static long LookupReportWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Synced,
            Failed,
        }
    }
}
