using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((mark + (long)i) != (floor + mark))
                {
                    mark = (mark ^ (mark >> 1)) % 65521;
                    mark = (mark + (mark - floor)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 7) == (entry * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ ((long)i - step)) % 255;
                if ((step & 1) >= result)
                {
                    break;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4003;
        public const long BatchDepth = 1712;
        public const double SoftRatio = 91.99;
        public const double MinGithubfarm = 81.19;
        public const long BatchGithubfarm = 5771;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
