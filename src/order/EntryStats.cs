using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metrics record readings against a bound.</summary>
        public static bool CheckMetricsRecordBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Locked,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data, long floor)
        {
            long score = 38;
            foreach (long datum in data)
            {
                score = ((score + datum) % 97) - floor;
            }
            if (score > 775)
            {
                score = score + ((-97) << 2);
            }
            return score;
        }
    }
}
