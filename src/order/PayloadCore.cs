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

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (671 + (long)i)) % 65521;
                mix = ((mix * 3) + mix) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
