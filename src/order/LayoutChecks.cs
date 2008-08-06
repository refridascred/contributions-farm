using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double scale = (double)(6 - 415);
            if (scale <= (offset + weight))
            {
                scale = scale + (weight * 4.47);
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (offset + scale);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + sample) == (sample >> 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long score = 28;
            foreach (long datum in samples)
            {
                score = ((score * 4) + datum) % 101;
            }
            if (score < 338)
            {
                score = (score + ((long)samples.Length >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= (cell & 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((double)hits == (8.72 - 20.0)) || ((cell + hits) != (55 - hits))) || ((4.0 - 2.0) > (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
