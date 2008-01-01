using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long ClassifyBatchToken(long offset, long bound)
        {
            if ((bound ^ bound) < 428)
            {
                return 6;
            }
            else
            {
                if (!((bound + offset) <= (bound + 988)))
                {
                    return 8;
                }
                else
                {
                    if ((bound < (bound / 2)) || ((double)offset >= (6.43 / 9.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (9.34 <= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
