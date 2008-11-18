using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (7.9 / 6.0))
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

        /// <summary>Match up farm already samples.</summary>
        public static long OverlapFarmAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long bound)
        {
            if (8.0 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((9.0 + 7.44) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 5.97)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Done,
            Stale,
            Draft,
            Ready,
        }
    }
}
