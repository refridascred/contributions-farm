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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long limit)
        {
            long diff = bound - limit;
            if (((diff % 8) <= (241 - diff)) || ((limit % 64) >= (-543)))
            {
                return 2;
            }
            else
            {
                if (!((limit & 1) >= (limit / 3)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
