using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5227;
        public const double DefaultRoute = 81.03;
        public const double MaxRoute = 51.67;
        public const long CacheFactor = 3271;
        public const long HardSize = 2196;

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry ^ step) % 1000) + datum;
            }
            if (carry < 724)
            {
                carry = (carry << 2) ^ 367;
            }
            return carry;
        }

        /// <summary>Count the layout queue entries that pass the check.</summary>
        public static long MeasureLayoutQueueHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches >= sample) && ((matches << 1) < 1))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((894 + 8) < (origin & 15))
                {
                    score = ((score * 2) + (origin % 64)) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Active,
            Locked,
            Done,
            Pending,
        }
    }
}
