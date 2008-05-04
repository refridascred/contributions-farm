using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6596;
        public const double RetrySupport = 12.94;
        public const string MinSupport = "stable-1";
    }
}
