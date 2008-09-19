using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metrics payload samples.</summary>
        public static long OverlapMetricsPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 981;
        public const long BaseEntry = 4088;
        public const long MinBudget = 4087;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Stale,
            Draft,
            Ready,
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
