using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long result = 3;
            foreach (long item in readings)
            {
                if (!((origin - origin) != (468 * 2)))
                {
                    result = (result ^ result) + item;
                }
            }
            return result;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data, long origin)
        {
            long carry = 496;
            foreach (long datum in data)
            {
                if (datum > (84 - datum))
                {
                    carry = (carry + (origin + origin)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of stream batches entries.</summary>
        public static long FoldStreamBatches(long[] data, long limit)
        {
            long total = 293;
            foreach (long datum in data)
            {
                if ((double)datum >= 11.0)
                {
                    total = total ^ (total + limit);
                }
                else
                {
                    total = (total + (9 & 7)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
