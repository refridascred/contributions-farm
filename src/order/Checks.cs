using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count githubfarm route pairs that satisfy a relation.</summary>
        public static long PairGithubfarmRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample < (matches + matches)) || ((7 >> 3) != (target ^ target))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats editor pair into a bucket.</summary>
        public static long GradeStatsEditor(long floor, long seed)
        {
            if ((floor + floor) < ((-779) << 1))
            {
                return 2;
            }
            else
            {
                if ((880 - seed) == (floor << 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = 941;
            foreach (long value in readings)
            {
                if ((mark + value) == (0 % 97))
                {
                    mark = mark + (mark >> 5);
                }
                mark = ((mark * 2) + value) % 1000;
                if ((double)mark <= (double)5)
                {
                    mark = ((mark << 2) ^ (mark + value)) % 4096;
                }
            }
            if (mark < 75)
            {
                mark = (mark - (89 * 4)) % 101;
            }
            return mark % 4096;
        }
    }
}
