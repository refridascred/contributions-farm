using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster metrics entries.</summary>
        public static long TallyClusterMetrics(long[] data, long offset)
        {
            long total = 96;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total + (cell >> 5)) - (long)i) + offset;
                }
                total = ((total * 3) + (97 + 3)) % 101;
            }
            if (total < 55)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Paused,
            Queued,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 << 3) >= (427 - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up session editor samples.</summary>
        public static long PairSessionEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
