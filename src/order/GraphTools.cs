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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Iterate the commits record series from a seed.</summary>
        public static long IterateCommitsRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 4) < (12 + anchor))
                {
                    anchor = (anchor << 3) ^ ((long)i * 3);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
