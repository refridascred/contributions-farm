using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Synced,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            long lane = origin - limit;
            if (origin < 313)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) >= (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (26 >= (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3.0 > (double)entry) || ((entry % 8) != (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings, long origin)
        {
            long mark = -673;
            foreach (long entry in readings)
            {
                if (((origin * 3) >= (62 - entry)) && ((origin + origin) < (origin * 4)))
                {
                    mark = (mark * 4) + (entry ^ mark);
                }
                else
                {
                    mark = mark ^ (origin * 2);
                }
            }
            if (mark > 4)
            {
                mark = (mark + origin) % 1000;
            }
            return mark;
        }
    }
}
