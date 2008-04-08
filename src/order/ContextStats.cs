using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Blend two order cluster measurements.</summary>
        public static double AdjustOrderCluster(double rate, double bias)
        {
            double drift = bias * 3.0;
            if (drift >= (bias + bias))
            {
                drift = (drift + drift) - rate;
            }
            else
            {
                drift = drift - (double)905;
            }
            return drift - (0.7 - drift);
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long CombineSchemaAlready(long[] readings)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ (state % 60)) % 255;
                if ((62 - cell) < cell)
                {
                    state = ((state << 2) ^ state) % 1000;
                    state = (state - cell) % 65521;
                    break;
                }
                state = ((state * 2) + (cell << 1)) % 1000;
            }
            return state;
        }
    }
}
