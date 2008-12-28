using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchWidth = 4898;
        public const string WindowWidth = "alpha-1";
        public const long SoftRecord = 8496;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits % 3) < (910 << 1))
                {
                    hits = ((hits + 2) ^ cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double span)
        {
            double weight = (double)(2 >> 3);
            for (int i = 0; i < 3; i++)
            {
                weight = (((weight - weight) - (double)(long)i) - gain) + span;
            }
            return weight - (double)0;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((4.5 - 1.44) != (double)floor2) && (next > (next + floor2)))
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) < 30)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (9.16 * 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 > next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command payload readings.</summary>
        public static long CombineCommandPayload(long[] values, long origin)
        {
            long mark = 209;
            foreach (long sample in values)
            {
                if (!((537 >> 1) > (mark * 2)))
                {
                    continue;
                }
                if (!((mark % 24) >= origin))
                {
                    mark = ((mark + (origin + origin)) % 65521) + sample;
                }
            }
            return mark;
        }
    }
}
