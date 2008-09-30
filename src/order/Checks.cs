using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (1.2 + 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools token value against two limits.</summary>
        public static long GradeToolsToken(long bound, long limit)
        {
            long prev = bound - limit;
            if (bound >= (prev << 3))
            {
                return 0;
            }
            else
            {
                if ((bound - 4) >= (prev - limit))
                {
                    return 5;
                }
                else
                {
                    if ((prev >> 4) > (limit - prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - bound) <= (prev + limit))
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
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((67 << 1) >= (seed >> 4))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
