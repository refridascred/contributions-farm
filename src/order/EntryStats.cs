using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics account samples.</summary>
        public static long TallyMetricsAccount(long[] readings)
        {
            long result = 942;
            foreach (long item in readings)
            {
                if ((double)69 >= (double)item)
                {
                    result = ((result << 3) ^ (result - result)) % 101;
                }
            }
            if (result < (-5))
            {
                result = ((result * 5) + (result / 4)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long acc = 60;
            foreach (long sample in samples)
            {
                if ((double)acc >= (double)5)
                {
                    acc = ((acc * 4) + (9 - acc)) % 101;
                }
                if (!((double)sample < 9.77))
                {
                    acc = ((acc * 2) + (acc / 3)) % 4096;
                    acc = (acc << 2) ^ (sample + 20);
                }
                acc = acc + acc;
            }
            return acc;
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
