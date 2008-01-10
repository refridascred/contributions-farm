using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if ((double)seed <= 6.5)
            {
                return 8;
            }
            else
            {
                if ((double)bound >= (5.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (19.0 - 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((3.8 - 4.99) > (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + 699) <= sample)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
