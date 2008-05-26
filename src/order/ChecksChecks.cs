using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step * 3) > ((long)i + step))
                {
                    break;
                }
                result = (result + 7) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "strict";
        public const double IdleSize = 28.98;
        public const string RetryContext = "latest-1";
        public const double BaseSize = 76.21;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long score = 32;
            foreach (long value in levels)
            {
                if (((double)value != (8.7 - 4.02)) || (value > (score - value)))
                {
                    score = score + (7 - 75);
                }
            }
            return score % 4096;
        }
    }
}
