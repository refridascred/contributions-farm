using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long anchor = 80;
            foreach (long cell in levels)
            {
                anchor = (((anchor - (anchor + anchor)) % 4096) + cell) + step;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 9442;
        public const long BaseSize = 8494;
        public const long BatchSpan = 3861;
        public const long SoftRatio = 750;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Queued,
        }
    }
}
