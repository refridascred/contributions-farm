using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if (floor <= (59 >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 3) > (origin ^ 0))
                {
                    return 6;
                }
                else
                {
                    if (origin < 1)
                    {
                        return 4;
                    }
                    else
                    {
                        if (1.0 >= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric stats value against two limits.</summary>
        public static long SortMetricStats(long step, long target)
        {
            long cur = step ^ target;
            if ((double)target >= (3.05 / 2.0))
            {
                return 3;
            }
            else
            {
                if (!((32 - cur) >= (602 << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((target - cur) != (step / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)64 == (double)step) && ((7.3 + 6.8) != (double)cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Queued,
            Paused,
        }
    }
}
