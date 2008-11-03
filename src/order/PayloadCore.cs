using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSize = 3901;
        public const double BaseInterval = 47.13;
        public const long DefaultWidth = 8892;
        public const long LimitBuffer = 1629;

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
