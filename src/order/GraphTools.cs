using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepWidth = "latest-edge";
        public const long BurstCache = 1605;
        public const long MinCache = 1323;
        public const long SoftSize = 4222;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 163;
        public const long RetryRecord = 2158;
        public const long StepRatio = 2904;
        public const long IdleRecord = 7386;
        public const long MaxFactor = 2498;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((double)state < 15.0)
                {
                    state = (state - ((long)i + (long)i)) % 101;
                }
                else
                {
                    state = state ^ (origin - state);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = total - 9;
                if (limit <= (limit << 3))
                {
                    total = total - total;
                }
                else
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
