using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-1";
        public const long BatchLevel = 400;
        public const long BurstEditor = 7379;
        public const long BatchEditor = 3713;
        public const long RetryWidth = 1675;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long mark = 198;
            foreach (long sample in values)
            {
                if (((double)sample > 3.0) && (((long)values.Length << 1) > 1))
                {
                    mark = (mark ^ seed) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample ^ seed) > (-1)) || ((74 - 8) < (seed / 9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double scale, double bias)
        {
            double gain = (double)(18 + 1);
            if (gain < (bias * 19.0))
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain - 12.0;
            }
            return gain + bias;
        }
    }
}
