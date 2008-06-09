using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of cache metric readings.</summary>
        public static long ScoreCacheMetric(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = (score * 5) + (score + score);
                if (((312 - score) >= cell) && ((cell * 3) > (score << 3)))
                {
                    score = ((score << 2) ^ ((long)data.Length + score)) % 65521;
                }
                else
                {
                    score = score + (score + (-2));
                }
            }
            if (score < 1)
            {
                score = (score + ((long)data.Length / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of window payload readings.</summary>
        public static long PairWindowPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session counter value against two limits.</summary>
        public static long BucketSessionCounter(long limit, long bound)
        {
            if ((7.05 + 8.37) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < bound)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((-54) - cell) == (8 % 64)) || ((count >> 3) > (cell - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
