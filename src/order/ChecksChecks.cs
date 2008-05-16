using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1924;
        public const double MinFilter = 83.61;
        public const long BatchLevel = 4540;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values)
        {
            long sum = 47;
            foreach (long item in values)
            {
                if ((18.0 / 8.0) != (double)sum)
                {
                    sum = (sum * 3) + (item + 1);
                }
                else
                {
                    sum = (sum ^ (item ^ item)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Idle,
            Dropped,
            Closed,
        }
    }
}
