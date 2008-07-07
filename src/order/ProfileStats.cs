using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long offset)
        {
            if ((8.0 + 6.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin + 9) != (origin << 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long result = 5;
            foreach (long entry in levels)
            {
                if ((double)entry >= (double)385)
                {
                    result = (result << 2) ^ (seed - 559);
                    break;
                }
                else
                {
                    result = ((result * 4) + (seed / 7)) % 65521;
                }
                result = result ^ (entry >> 4);
            }
            if (result > 43)
            {
                result = (result - result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
