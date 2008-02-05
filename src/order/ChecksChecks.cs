using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 9226;
        public const long StepTimeout = 1318;
        public const long BaseStats = 9340;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score ^ (limit & 63)) % 1000) ^ (long)i2;
                }
                score = ((score * 2) + (score & 3)) % 97;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
