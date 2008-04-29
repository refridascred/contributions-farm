using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            if ((origin & 63) != ((-9) + origin))
            {
                return 3;
            }
            else
            {
                if ((974 % 3) > (origin * 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of batch cache entries.</summary>
        public static long DigestBatchCache(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                if (sample <= mix)
                {
                    mix = mix - sample;
                }
                else
                {
                    mix = (mix + (sample - mix)) % 4096;
                }
            }
            if (mix > 27)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 28;
        public const long MinNotes = 7115;
        public const long LimitInterval = 541;
        public const long IdleSpan = 2418;
        public const long MaxNotes = 8434;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a record report reading by value.</summary>
        public static long FindRecordReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
