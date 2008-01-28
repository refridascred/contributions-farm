using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a payload cache pair into a bucket.</summary>
        public static long RankPayloadCache(long offset, long seed)
        {
            if ((9.12 + 5.2) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset >= (13 % 100))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long bound)
        {
            if ((8.1 / 6.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((step & 1) >= (bound % 100))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= (0.2 - 6.35))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound != (double)step) || ((58 + step) >= (step + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
