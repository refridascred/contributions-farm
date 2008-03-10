using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if (!((double)limit <= 13.0))
            {
                return 1;
            }
            else
            {
                if ((82 + 479) <= (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit >= (4 + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if (49 < (seed / 6))
                {
                    mark = ((mark * 5) + seed) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (seed + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((76 - seen) < bound))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }
    }
}
