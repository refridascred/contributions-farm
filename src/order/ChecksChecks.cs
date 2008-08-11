using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double rate = span * 2.97;
            if (rate <= (scale + scale))
            {
                rate = rate + 2.0;
            }
            else
            {
                rate = rate - 0.2;
            }
            return rate - span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
