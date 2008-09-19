using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 96.23;
        public const long DefaultQueue = 4998;
        public const long BaseQueue = 6350;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 981;
        public const long BaseEntry = 4088;
        public const long MinBudget = 4087;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Stale,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings, long offset)
        {
            long state = 298;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 5) + (state & 1)) % 4096) ^ (long)i;
                }
                state = (state * 2) + ((long)readings.Length & 15);
                if ((value >= (state << 1)) || ((4 - offset) >= state))
                {
                    state = (state - (33 / 3)) % 255;
                }
            }
            return state;
        }
    }
}
