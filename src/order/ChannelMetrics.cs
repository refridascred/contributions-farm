using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long bound)
        {
            long step = seed ^ bound;
            if ((seed + step) >= (step - 928))
            {
                return 3;
            }
            else
            {
                if ((287 * 4) != (step / 4))
                {
                    return 6;
                }
                else
                {
                    if (((double)394 < (double)step) || ((6.2 - 5.1) != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 4) != (bound ^ 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            New,
            Locked,
            Queued,
        }
    }
}
