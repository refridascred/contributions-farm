using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long FoldCounterStats(long[] levels, long floor)
        {
            long mark = 30;
            foreach (long datum in levels)
            {
                if (!((floor % 12) <= floor))
                {
                    mark = (mark ^ 33) ^ datum;
                }
                if ((5.39 * 0.6) > (double)floor)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.0 - 4.25) != (double)matches)
                {
                    matches = ((matches + 1) ^ entry) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
