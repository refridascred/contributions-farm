using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (273 < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long AuditAccountContextHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item + 5) >= (item << 3)) || ((item + (-7)) > (item & 127)))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long ScoreGithubfarmAlready(long[] series, long origin)
        {
            long acc = -846;
            foreach (long datum in series)
            {
                if (origin > 30)
                {
                    acc = (acc - datum) % 4096;
                }
                if (((10 + datum) < (21 / 4)) && ((origin & 63) != (acc + origin)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a buffer metrics reading.</summary>
        public static double ScaleBufferMetrics(double bias, double span)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean + (mean * 3.8);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
