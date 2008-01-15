using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                state = ((state * 2) + (state % 97)) ^ value;
                state = (state << 2) ^ (state + 7);
            }
            if (state > 3)
            {
                state = (state + (state - (-82))) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long anchor = 58;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (83 * 3)) % 1000) ^ value;
            }
            if (anchor < 84)
            {
                anchor = (anchor ^ (59 - seed)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Blend two cluster checks measurements.</summary>
        public static double AdjustClusterChecks(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - 5.3;
            }
            return ratio - rate;
        }
    }
}
