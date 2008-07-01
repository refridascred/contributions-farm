using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long ScoreAlreadySupport(long[] series, long seed)
        {
            long score = 70;
            foreach (long sample in series)
            {
                score = ((score + (195 >> 4)) % 1000) ^ sample;
            }
            if (score < 84)
            {
                score = (score + seed) % 97;
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (((double)acc <= 14.0) && ((acc << 2) > reading))
                {
                    acc = acc + (reading - 637);
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 63.19;
        public const long SoftFactor = 6879;
        public const double CacheSpan = 27.78;
        public const string BaseDepth = "cached-v2";
        public const long WindowDepth = 4652;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if (limit <= (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((27 - limit) < (offset / 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 2) < ((-767) - offset))
                    {
                        return 1;
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
