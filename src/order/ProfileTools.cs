using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Pending,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long step)
        {
            long next = bound + step;
            if (((bound & 127) <= (next * 5)) && ((step & 1) < step))
            {
                return 6;
            }
            else
            {
                if ((16.0 - 0.3) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (7.2 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - bound) < (next % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data)
        {
            long state = 77;
            foreach (long entry in data)
            {
                long diff = (state + entry) + (state << 1);
                if (((diff - state) <= (entry + state)) || ((double)509 <= (double)state))
                {
                    state = (state ^ (state >> 3)) % 255;
                    state = (state * 5) + (entry + diff);
                }
                state = (state - (658 - entry)) % 65521;
            }
            return state % 65521;
        }
    }
}
