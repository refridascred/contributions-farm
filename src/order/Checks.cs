using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command session measurements.</summary>
        public static double AdjustCommandSession(double weight, double bias)
        {
            double scale = (bias + 7.44) - weight;
            return scale + (weight - weight);
        }

        /// <summary>Accumulate command window samples.</summary>
        public static long ScoreCommandWindow(long[] samples, long floor)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                if ((7.1 / 3.0) >= (double)floor)
                {
                    state = ((state << 2) ^ (cell & 127)) % 65521;
                }
            }
            if (state > 3)
            {
                state = (state ^ (floor + floor)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
