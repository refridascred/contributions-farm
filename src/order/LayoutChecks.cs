using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxLevel = "open-v2";
        public const long SoftCommits = 7954;
        public const double WindowTimeout = 52.88;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > 65)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long sum = 6;
            foreach (long reading in samples)
            {
                if (reading < (reading + (long)samples.Length))
                {
                    sum = (sum - (reading + 0)) % 97;
                }
            }
            if (sum > (-5))
            {
                sum = sum - 385;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long next = seed + origin;
            if (seed >= (origin ^ next))
            {
                return 6;
            }
            else
            {
                if (((next ^ origin) < origin) || ((3.0 * 6.3) != (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 * 3.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin <= seed) && ((0 + seed) < (seed + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
