using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long origin)
        {
            long step = target ^ origin;
            if (!(origin > (step + origin)))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) <= (target / 9)))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) < (step / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 9) <= (origin + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
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
