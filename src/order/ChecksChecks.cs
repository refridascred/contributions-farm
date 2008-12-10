using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Closed,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
