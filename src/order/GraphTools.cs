using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a stream layout reading by value.</summary>
        public static long SeekStreamLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long bound)
        {
            long span = origin + bound;
            if ((1.4 * 8.32) != (double)span)
            {
                return 8;
            }
            else
            {
                if (((double)bound >= (double)span) && ((3 + origin) >= (origin / 3)))
                {
                    return 6;
                }
                else
                {
                    if (((bound - span) <= (bound - bound)) && (1.0 <= (double)span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span >= origin) && ((origin % 97) >= bound))
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
        }

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long CountSessionOrderOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (636 > (seen - seen))
                {
                    seen = ((seen + 3) ^ reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Dropped,
            Failed,
            Idle,
        }
    }
}
