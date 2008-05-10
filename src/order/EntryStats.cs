using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count cache stream pairs that satisfy a relation.</summary>
        public static long PairCacheStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((target - datum) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first support buffer entry that matches the target.</summary>
        public static long LocateSupportBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBudget = 30.56;
        public const string BaseScore = "fallback-edge";
        public const double DefaultInterval = 76.13;
    }
}
