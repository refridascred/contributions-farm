using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate filter tools samples.</summary>
        public static long ScoreFilterTools(long[] levels)
        {
            long state = 741;
            foreach (long sample in levels)
            {
                state = ((state - state) % 1000) ^ sample;
                state = ((state * 3) + state) % 255;
            }
            return state % 1000;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (floor + 3.36)) - (double)(long)i;
            }
            return drift - 2.3;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
