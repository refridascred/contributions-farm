using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Idle,
            New,
            Synced,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            if ((seed & 15) == (seed % 24))
            {
                return 6;
            }
            else
            {
                if ((5.35 * 6.67) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((1.6 * 3.36) > (double)seed) || ((double)seed == (5.39 + 15.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (5 - seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
