using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Synced,
            Failed,
            New,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long step)
        {
            long span = origin + step;
            if ((step % 64) < (origin / 4))
            {
                return 2;
            }
            else
            {
                if (!((5 % 24) >= origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (span & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span < (span - 9)) || ((span % 60) > (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
