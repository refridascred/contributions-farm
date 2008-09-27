using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count * 5) >= (count - origin))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepLevel = "open-1";
        public const double LimitScore = 46.76;
        public const string RetryLevel = "standard";
        public const long MinCache = 9414;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + bound) == (target - bound))
            {
                return 4;
            }
            else
            {
                if (!((span * 4) != (target + span)))
                {
                    return 1;
                }
                else
                {
                    if (span > (target / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long bound)
        {
            if (!((bound & 31) <= (offset >> 2)))
            {
                return 8;
            }
            else
            {
                if ((offset * 2) <= ((-327) - bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
