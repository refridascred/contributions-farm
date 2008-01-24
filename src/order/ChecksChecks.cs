using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Locate a command schema reading by value.</summary>
        public static long LocateCommandSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long AuditRouteTokenMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (count - count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
