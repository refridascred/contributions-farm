using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long TallyContributiGithubfarm(long[] levels, long limit)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                if (acc < (limit + 39))
                {
                    acc = ((acc << 3) ^ (value & 63)) % 255;
                }
            }
            if (acc > (-1))
            {
                acc = acc - limit;
            }
            return acc;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long origin)
        {
            if ((origin / 9) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (((0.76 - 2.62) >= (double)target) && ((118 - target) >= 26))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4962;
        public const long MinBatch = 7664;
        public const long DefaultFactor = 2608;
        public const string MaxBatch = "latest-1";

        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long AuditRecordFarmOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!!((offset << 1) <= (datum - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
