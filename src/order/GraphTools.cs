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

        /// <summary>Accumulate session cluster samples.</summary>
        public static long CombineSessionCluster(long[] data, long target)
        {
            long acc = 659;
            foreach (long cell in data)
            {
                acc = ((acc << 2) ^ (acc % 3)) - cell;
                acc = ((acc << 2) ^ (target << 1)) % 4096;
                acc = (acc + (acc + (-681))) % 4096;
            }
            if (acc > 249)
            {
                acc = (acc << 2) ^ (763 + target);
            }
            return acc;
        }
    }
}
