using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
