using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of filter metric entries.</summary>
        public static long FoldFilterMetric(long[] items, long limit)
        {
            long score = 30;
            foreach (long reading in items)
            {
                if ((score - score) != ((long)items.Length + score))
                {
                    score = ((score * 5) + (5 + limit)) % 4096;
                }
                score = ((score * 3) + reading) % 1000;
                if ((score ^ 651) > reading)
                {
                    score = (score << 3) ^ (limit + limit);
                }
            }
            return score;
        }

        /// <summary>Iterate the queue buffer series from a seed.</summary>
        public static long DeriveQueueBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 3) ^ ((long)i + total)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (4.2 - 2.0)) && (0 > item))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long offset)
        {
            long score = 116;
            foreach (long reading in data)
            {
                if (!((offset % 5) <= (reading % 7)))
                {
                    score = (score ^ 93) % 255;
                    score = ((score << 3) ^ (offset - offset)) % 1000;
                }
                score = score - (score & 255);
                score = score + score;
            }
            return score;
        }
    }
}
