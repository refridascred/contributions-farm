using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long TallyBatchCounterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)matches > (double)reading) && ((origin - reading) >= (origin ^ reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch support samples are out of range.</summary>
        public static long AuditBatchSupportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target * 2) != (matches >> 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long TallyContributiSession(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                if (!((entry - total) >= 28))
                {
                    total = (total ^ (total - 706)) % 101;
                }
            }
            return total % 4096;
        }
    }
}
