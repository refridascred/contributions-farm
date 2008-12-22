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

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long target)
        {
            long mark = 8;
            foreach (long sample in items)
            {
                if ((8 / 6) >= sample)
                {
                    mark = (mark ^ (mark << 3)) - target;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
