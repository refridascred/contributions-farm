using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long bound)
        {
            if (origin < (origin * 5))
            {
                return 4;
            }
            else
            {
                if (!((bound + bound) <= (bound + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 64) >= (origin % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if (((score << 3) < score) && ((double)step <= (7.14 / 8.0)))
                {
                    score = score - (score - score);
                }
                else
                {
                    score = (score - (step + (long)i)) % 65521;
                }
                score = (score * 3) + ((long)i << 3);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
