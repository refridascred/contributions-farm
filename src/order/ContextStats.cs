using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long slot = limit ^ target;
            if ((6.0 < (double)target) && ((double)target == (20.0 - 7.3)))
            {
                return 0;
            }
            else
            {
                if (!((slot * 2) >= (limit + target)))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ (-48)) < slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((300 & 255) > slot)
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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Locked,
            Queued,
            Stale,
            New,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5982;
        public const long LimitToken = 8265;
        public const string RetryToken = "local-1";
        public const long WindowDepth = 6852;
    }
}
