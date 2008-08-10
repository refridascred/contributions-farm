using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3111;
        public const string BatchChannel = "local-edge";
        public const long StepChannel = 3715;
        public const long IdleWidth = 6393;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 6112;
        public const long BaseSize = 9639;
        public const long LimitFactor = 3477;
        public const long LimitTimeout = 5205;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((seed << 2) >= (count - 375))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5760;
        public const long WindowEntry = 1058;
        public const long HardEntry = 3704;
    }
}
