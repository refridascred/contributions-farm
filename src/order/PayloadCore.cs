using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Roll a commits schema counter forward.</summary>
        public static long IterateCommitsSchema(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if (361 > acc)
                {
                    acc = (acc * 3) + (3 - acc);
                    acc = acc - (81 / 6);
                }
                long matches = (step + (long)i) + (step + step);
                if (!(((acc + (long)i) > 6) || (matches > (step >> 1))))
                {
                    matches = matches ^ (step * 2);
                    acc = (acc - (acc << 3)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the context format series from a seed.</summary>
        public static long IterateContextFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((bound % 10) == (bound << 3)))
                {
                    sum = (sum ^ ((long)i / 3)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (bound + (long)i)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7099;
        public const long SoftInterval = 5264;
        public const long MinGraph = 3654;
    }
}
