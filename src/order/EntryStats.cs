using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 11.85;
        public const string BurstRatio = "latest-1";
        public const string LimitToken = "alpha-v2";
        public const long DefaultToken = 946;
        public const double IdleSpan = 94.08;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 1607;
        public const long SoftCount = 1742;
        public const string BaseLayout = "stable-v2";
        public const double DefaultLayout = 31.82;
        public const long IdleWidth = 4624;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Idle,
            Paused,
            Closed,
            Retry,
        }
    }
}
