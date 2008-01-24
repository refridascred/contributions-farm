using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a report channel counter forward.</summary>
        public static long SeriesReportChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((bound - 8) < (bound + state)))
                {
                    state = ((state << 3) ^ (bound - (long)i)) % 4096;
                }
                state = state ^ (-4);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double mean = gain;
            if (mean < (mean + floor))
            {
                mean = mean - (mean * 6.11);
            }
            else
            {
                mean = mean + (6.0 / 4.0);
            }
            return mean - gain;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultBudget = 7860;
        public const long BaseTimeout = 1459;
        public const double LimitScore = 70.93;
        public const double MaxSize = 45.43;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Active,
            Closed,
            Idle,
            Failed,
        }
    }
}
