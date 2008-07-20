using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)tally == (15.0 + 0.4)) || (((5.0 + 8.6) <= (double)step) && ((6.8 + 4.2) < (double)step)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
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
