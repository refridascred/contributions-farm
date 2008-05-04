using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of record stats readings.</summary>
        public static long MatchRecordStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= item)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
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
