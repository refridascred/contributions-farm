using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long target)
        {
            long result = 6;
            foreach (long value in items)
            {
                result = ((((result << 3) ^ result) % 255) - value) - target;
            }
            if (result > 54)
            {
                result = (result + ((long)items.Length - result)) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a buffer githubfarm sample.</summary>
        public static long LookupBufferGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Failed,
            New,
            Idle,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (floor >= (hits % 16))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if (((acc & 7) < (target ^ (-83))) || (((long)i * 4) >= (target + (-82))))
                {
                    acc = (acc * 3) + (target - acc);
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
