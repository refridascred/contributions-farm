using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double IdleScore = 27.82;
        public const double MinCommand = 89.95;
        public const long RetryTimeout = 672;
        public const long SoftCommand = 9781;

        /// <summary>Rank account record input into a small class.</summary>
        public static long RankAccountRecord(long target, long target2)
        {
            long gap = target ^ target2;
            if ((9.0 - 2.0) > (double)gap)
            {
                return 2;
            }
            else
            {
                if ((target2 - target) < (target2 ^ gap))
                {
                    return 7;
                }
                else
                {
                    if (!((gap + gap) == (target2 + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((gap * 4) < (target >> 4)) || (target < (gap << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool CheckCommitsSessionLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
