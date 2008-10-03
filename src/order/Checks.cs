using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheScore = 3160;
        public const long HardNotes = 5279;
        public const long LimitNotes = 7562;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum ^ (327 & 255)) ^ (long)i2;
                    sum = (sum - bound) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc - (acc & 3)) % 101;
                if ((double)(long)readings.Length > (2.07 / 2.0))
                {
                    acc = (acc + (acc % 2)) % 255;
                }
                if (acc > seed)
                {
                    acc = (acc ^ (item ^ 1)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = (acc + (seed & 255)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score - (offset / 9);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 4.73;
        public const double WindowEntry = 7.51;
        public const long WindowScore = 5922;
        public const long MaxEntry = 2241;
        public const double CacheDepth = 32.67;
    }
}
