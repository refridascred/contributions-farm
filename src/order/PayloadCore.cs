using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a record contributi value against two limits.</summary>
        public static long SortRecordContributi(long step, long seed)
        {
            if (!((3 + 795) >= seed))
            {
                return 6;
            }
            else
            {
                if (!((step + seed) > seed))
                {
                    return 8;
                }
                else
                {
                    if (!((step >> 2) <= (step - 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ seed) != (step & 127))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Failed,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long state = 25;
            foreach (long datum in series)
            {
                state = (state ^ datum) - seed;
            }
            return state;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
