using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine command metrics values into a single score.</summary>
        public static long CombineCommandMetrics(long[] values)
        {
            long total = 13;
            foreach (long value in values)
            {
                total = ((total << 2) ^ 334) ^ value;
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (1.25 > (double)anchor)
                {
                    anchor = (anchor + (anchor - 80)) % 255;
                }
                anchor = anchor ^ (119 - anchor);
                if (anchor < origin)
                {
                    anchor = (anchor * 5) + anchor;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Closed,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long sum = 948;
            foreach (long entry in levels)
            {
                if ((sum << 3) <= (entry - 171))
                {
                    sum = sum ^ sum;
                }
                if (!(entry > (limit * 3)))
                {
                    sum = sum ^ (limit + limit);
                }
            }
            if (sum > 669)
            {
                sum = ((sum * 2) + (limit << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
