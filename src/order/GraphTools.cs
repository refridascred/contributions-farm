using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a graph metric reading by value.</summary>
        public static long SeekGraphMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Failed,
            Idle,
            Dropped,
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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long result = 724;
            foreach (long item in items)
            {
                result = (result ^ (origin << 3)) ^ item;
                if ((result >> 5) <= (origin / 6))
                {
                    result = (result * 3) + (result + origin);
                }
                else
                {
                    result = result + origin;
                }
            }
            return result;
        }
    }
}
