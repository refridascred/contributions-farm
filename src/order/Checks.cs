using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long floor)
        {
            long offset = seed - floor;
            if (!((61 % 8) == (floor & 15)))
            {
                return 0;
            }
            else
            {
                if ((offset ^ seed) > (offset % 100))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first token layout entry that matches the target.</summary>
        public static long FindTokenLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (acc << 2)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ datum) - offset;
                if ((sum % 3) <= (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
