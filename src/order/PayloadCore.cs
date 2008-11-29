using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (9.9 - 0.31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Active,
            Idle,
            Failed,
            Ready,
        }
    }
}
