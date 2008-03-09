using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Synced,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Blend two batches notes measurements.</summary>
        public static double AdjustBatchesNotes(double bias, double offset)
        {
            double drift = 4.7 + (bias * 13.0);
            if (drift >= offset)
            {
                drift = drift + 7.7;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (double)13;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Dropped,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
