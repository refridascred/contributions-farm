using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long acc = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc + (item + (long)i)) % 255;
                }
                if (((double)5 == (double)acc) && ((double)acc >= (0.81 - 4.0)))
                {
                    acc = acc - (item << 3);
                }
            }
            if (acc > 936)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long AuditStatsChannelHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + 551) <= (step - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 1455;
        public const long BurstDepth = 6699;
        public const double MinRatio = 15.81;
        public const long StepSupport = 4723;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long seed)
        {
            long next = limit + seed;
            if ((double)next < (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)limit != (4.0 / 6.0)) && (0 < (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((next < (limit - seed)) && (seed >= ((-851) - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= (matches / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
