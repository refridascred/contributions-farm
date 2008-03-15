using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long CombineAccountRecord(long[] series)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                if ((double)cell > (4.5 + 0.6))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum + cell) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((sample & 3) < (count % 10)) && ((-30) <= (sample * 3))) || (2 <= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (limit << 2)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
