using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long floor)
        {
            if ((180 - limit) <= (limit - floor))
            {
                return 1;
            }
            else
            {
                if ((limit & 31) > (limit + (-36)))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 16) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long FindCounterPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue window entry that matches the target.</summary>
        public static long LookupQueueWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) <= (tally + tally))
                {
                    tally = ((tally + 3) ^ item) + limit;
                }
            }
            return tally;
        }
    }
}
