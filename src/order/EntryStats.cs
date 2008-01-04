using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)63 > (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long floor)
        {
            if ((floor - floor) != (limit + limit))
            {
                return 2;
            }
            else
            {
                if (limit > (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor <= (1.3 * 8.0)) && ((double)limit != (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
