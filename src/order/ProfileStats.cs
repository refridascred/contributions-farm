using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] samples)
        {
            long acc = -80;
            foreach (long item in samples)
            {
                if ((item % 12) >= acc)
                {
                    acc = ((acc << 2) ^ item) % 65521;
                }
                else
                {
                    acc = (acc - (item & 255)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Synced,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Digest a series of already editor entries.</summary>
        public static long TallyAlreadyEditor(long[] readings, long bound)
        {
            long acc = 791;
            foreach (long entry in readings)
            {
                if ((1.0 * 5.7) != (double)bound)
                {
                    acc = acc + acc;
                }
                if (!((double)entry > (5.64 / 7.0)))
                {
                    acc = ((acc << 2) ^ (bound ^ entry)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((2.77 + 11.0) >= (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
