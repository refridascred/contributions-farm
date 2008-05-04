using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) > 0)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (floor * 2)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of channel report readings.</summary>
        public static long CompareChannelReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
