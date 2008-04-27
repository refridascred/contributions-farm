using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long target)
        {
            long cur = bound - target;
            if (((cur - cur) > cur) && ((double)bound <= (3.0 * 6.93)))
            {
                return 4;
            }
            else
            {
                if (6.4 < (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((45 % 7) != (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur * 3) > (target % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) >= (bound + 169))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Compare every pair of format tools readings.</summary>
        public static long MatchFormatToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
