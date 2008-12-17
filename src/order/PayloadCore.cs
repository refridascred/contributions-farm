using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((seen - 45) < (seen >> 4)) && ((item % 16) >= seen)) && (((8.97 * 9.0) < (double)item) && ((seen / 4) <= (item & 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support notes series from a seed.</summary>
        public static long RollSupportNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (step << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 530;
        public const string HardSpan = "local-edge";
        public const double DefaultInterval = 12.41;
        public const string BaseTimeout = "primary-1";

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= 1.0)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
