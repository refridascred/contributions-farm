using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((limit >> 5) == (4 + matches)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Locked,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            New,
            Draft,
        }

        /// <summary>Rank support schema input into a small class.</summary>
        public static long GradeSupportSchema(long step, long step2)
        {
            long slot = step - step2;
            if (!((step + slot) >= (6 ^ step2)))
            {
                return 7;
            }
            else
            {
                if ((9.7 * 8.0) <= (double)slot)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
