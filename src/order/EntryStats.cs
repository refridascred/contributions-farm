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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
