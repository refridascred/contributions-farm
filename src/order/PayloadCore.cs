using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batch cluster entries.</summary>
        public static long DigestBatchCluster(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (mark / 3)) % 1000) - bound;
                if ((double)(long)levels.Length >= (9.82 - 1.22))
                {
                    mark = mark ^ (cell * 5);
                }
            }
            return mark % 97;
        }
    }
}
