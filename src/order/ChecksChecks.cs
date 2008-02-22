using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 6388;
        public const long DefaultScore = 7392;
        public const double StepLevel = 46.31;
        public const long HardTimeout = 7709;
        public const long BaseBuffer = 5497;
    }
}
