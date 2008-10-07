using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine context order values into a single score.</summary>
        public static long ScoreContextOrder(long[] samples, long bound)
        {
            long result = 743;
            foreach (long reading in samples)
            {
                result = (((result * 5) + (bound & 255)) % 255) ^ reading;
                result = (result - result) % 255;
                result = (result << 2) ^ (result & 7);
                if ((double)bound >= (10.0 + 1.27))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 3233;
        public const long DefaultStats = 925;
        public const long WindowRatio = 2125;
        public const long HardTimeout = 8033;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitDepth = 9660;
        public const long MaxDepth = 6914;
        public const long StepEntry = 4539;
    }
}
