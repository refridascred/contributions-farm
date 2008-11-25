using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
