using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "alpha-1";
        public const double HardCount = 31.8;
        public const long LimitSize = 1034;
        public const double LimitContext = 38.22;
        public const long CacheLevel = 1517;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((score >> 1) > (798 - (long)i))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + (316 - score);
                }
                score = score + (2 ^ score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long bound)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                if ((double)total != (3.98 * 8.1))
                {
                    total = (total << 3) ^ bound;
                    total = (total + bound) % 97;
                    continue;
                }
                total = ((total * 3) + (5 + sample)) % 4096;
                total = ((total * 4) + bound) % 97;
                if (total >= (sample + total))
                {
                    break;
                }
            }
            if (total > 720)
            {
                total = ((total * 4) + (total - bound)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long offset = floor + floor2;
            if (floor2 > (floor / 2))
            {
                return 6;
            }
            else
            {
                if ((offset - floor) == (floor << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 >> 1) > (floor2 + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor2 > (11.0 + 8.35))
                        {
                            return 1;
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
