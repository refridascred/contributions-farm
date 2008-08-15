using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TallyChannelCounter(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = ((mix ^ mix) % 1000) + cell;
                mix = mix ^ (offset + 96);
            }
            return mix % 65521;
        }

        /// <summary>Audit session stream readings against a rule.</summary>
        public static long CountSessionStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - reading) > (629 + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long target, long origin)
        {
            long bound = target + origin;
            if (((9 - bound) > bound) && (origin > (target & 127)))
            {
                return 2;
            }
            else
            {
                if ((bound & 31) < (77 % 3))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches farm reading by value.</summary>
        public static long LocateBatchesFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
