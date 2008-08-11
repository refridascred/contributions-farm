using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            New,
            Pending,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((mark + (cell + 65)) % 255) + limit;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
