using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const long SoftLevel = 9920;
        public const long StepRatio = 4061;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 4344;
        public const double IdleInterval = 94.01;
        public const long BatchCommand = 40;

        /// <summary>Match up filter queue samples.</summary>
        public static long OverlapFilterQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool CheckAccountContributiBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
