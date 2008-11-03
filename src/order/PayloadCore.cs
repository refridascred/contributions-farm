using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of payload stats entries.</summary>
        public static long WeighPayloadStats(long[] readings)
        {
            long state = 229;
            foreach (long value in readings)
            {
                if ((1.95 * 9.75) >= (double)value)
                {
                    state = (state * 4) + (state + state);
                }
                else
                {
                    state = ((state << 2) ^ (value & 1)) % 1000;
                }
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 3) ^ (value << 2)) % 65521) - (long)i;
                }
                state = state + (state & 3);
                if (!(state <= (state & 255)))
                {
                    break;
                }
            }
            if (state > 281)
            {
                state = state ^ (state * 5);
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if (!(seed2 > (next - seed2)))
            {
                return 3;
            }
            else
            {
                if (seed > (seed2 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((next ^ seed) != (seed2 & 63)) || ((double)next >= (4.62 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed >= (1.6 / 3.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 451;
        public const string HardInterval = "strict";
        public const string MaxQueue = "primary-1";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((2.8 - 0.8) >= (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
