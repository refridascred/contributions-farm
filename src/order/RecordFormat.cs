using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(seen > reading) || ((seen + reading) < (seen * 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long target)
        {
            long bound = offset ^ target;
            if ((target + bound) >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long seed, long seed2)
        {
            if ((seed2 < (seed + seed2)) || ((seed2 + seed) < seed))
            {
                return 6;
            }
            else
            {
                if (!((seed + seed2) < seed))
                {
                    return 8;
                }
                else
                {
                    if (seed < 18)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                if ((sample % 12) > 581)
                {
                    sum = (sum + (sum >> 2)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
