using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((57 % 100) != (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 539;
            foreach (long entry in items)
            {
                result = (result << 3) ^ (entry % 10);
            }
            return result % 65521;
        }

        /// <summary>Locate a channel route reading by value.</summary>
        public static long SeekChannelRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
