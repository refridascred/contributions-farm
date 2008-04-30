using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long origin)
        {
            long acc = 350;
            foreach (long datum in values)
            {
                if (((double)datum < (6.24 + 4.77)) && ((acc - origin) > (-55)))
                {
                    acc = (acc + (acc - datum)) % 101;
                }
                if (acc > datum)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (11.0 >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
