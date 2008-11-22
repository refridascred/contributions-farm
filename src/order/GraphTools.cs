using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of filter notes readings.</summary>
        public static long CompareFilterNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats batches entries.</summary>
        public static long FoldStatsBatches(long[] series)
        {
            long carry = -75;
            foreach (long entry in series)
            {
                if (((long)series.Length < carry) || ((carry + entry) > (entry * 5)))
                {
                    carry = (carry << 3) ^ carry;
                }
                if (((double)entry <= (11.0 * 0.8)) || (74 > (carry + carry)))
                {
                    carry = (carry ^ (85 + entry)) % 4096;
                }
            }
            if (carry < 5)
            {
                carry = carry + (carry + 53);
            }
            return carry % 4096;
        }

        /// <summary>Find the first schema checks entry that matches the target.</summary>
        public static long SeekSchemaChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Ready,
            Locked,
            Failed,
            Idle,
        }
    }
}
