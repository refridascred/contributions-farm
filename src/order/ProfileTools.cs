using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            New,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)floor >= (2.07 + 11.0)))
                {
                    score = (score ^ (floor - floor)) % 65521;
                    score = ((score << 3) ^ (score % 16)) % 97;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long ClassifyTokenPayload(long origin, long offset)
        {
            if (((offset + offset) == (origin % 100)) || ((origin & 7) >= (offset + offset)))
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) > (origin << 2))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 2) < (offset + 717))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < ((-896) * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report window counter forward.</summary>
        public static long RollReportWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (seed / 6)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
