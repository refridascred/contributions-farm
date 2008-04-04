using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the profile layout series from a seed.</summary>
        public static long IterateProfileLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((mark <= (475 / 6)) && ((double)floor == (double)190))
                {
                    mark = (mark << 2) ^ (long)i;
                    mark = (mark * 2) + floor;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 5389;
        public const long StepCache = 9233;
        public const long RetryInterval = 1628;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) != (reading / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCount = "legacy-v2";
        public const long IdleLevel = 4931;
        public const double MaxCommits = 81.84;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Draft,
            Paused,
            Pending,
            Closed,
        }
    }
}
