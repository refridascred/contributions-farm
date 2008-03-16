using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - sum) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen << 1) > seen) || (6 <= (sample ^ origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window token value from a seed.</summary>
        public static long IterateWindowToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (seed < (748 % 97))
            {
                return 1;
            }
            else
            {
                if (((seed / 5) <= (offset << 3)) || ((3.8 / 3.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((9.4 + 0.3) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >= (954 - bound)) && (seed >= (offset >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
