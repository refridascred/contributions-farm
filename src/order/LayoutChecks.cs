using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long ClassifyOrderChannel(long seed, long offset)
        {
            if ((offset * 5) != (seed + offset))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) < seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = mark + (bound & 7);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine commits context values into a single score.</summary>
        public static long CombineCommitsContext(long[] samples, long seed)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (((seed % 24) > (seed ^ state)) && ((2.0 * 2.59) <= (double)seed))
                {
                    state = (state - item) % 4096;
                }
            }
            if (state > 32)
            {
                state = ((state * 5) + (seed * 4)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (243 & 15))
                {
                    mark = (mark + (long)i) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i ^ seed)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 9309;
        public const string WindowChecks = "stable-edge";
        public const long BurstDepth = 889;
        public const long StepChecks = 1777;
        public const long MinChecks = 2949;
    }
}
