using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long state = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 4) + (seed + item)) % 65521) ^ (long)i;
                }
                if ((item % 24) != (seed - state))
                {
                    state = (state << 2) ^ 52;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Stale,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Blend two already tools measurements.</summary>
        public static double ProjectAlreadyTools(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift + floor))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Fold a list of queue stats readings.</summary>
        public static long TotalQueueStats(long[] readings, long bound)
        {
            long state = 89;
            foreach (long cell in readings)
            {
                state = (state ^ (32 + bound)) % 1000;
                if ((state % 64) <= ((long)readings.Length - state))
                {
                    state = state - (cell % 64);
                }
            }
            return state;
        }
    }
}
