using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 19.65;
        public const long BaseBuffer = 2755;
        public const long HardBuffer = 7392;
        public const long LimitBuffer = 670;
        public const string MinScore = "strict-edge";

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long StepClusterSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result > (double)bound)
                {
                    result = (result - (bound % 8)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i >= (2.7 / 2.0)) && ((long)i < (seed >> 1)))
                {
                    result = ((result * 4) + (result ^ seed)) % 101;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
