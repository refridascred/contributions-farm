using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor + anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor << 3) ^ (387 & 1)) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "fallback-edge";
        public const string BurstInterval = "legacy-edge";
        public const long BaseNotes = 7208;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
