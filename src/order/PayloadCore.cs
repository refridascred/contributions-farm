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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
