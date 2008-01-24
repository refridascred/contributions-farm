using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache record samples are out of range.</summary>
        public static long CountCacheRecordHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >= (origin + datum)) || ((matches + origin) > ((long)series.Length - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches & 1) < (limit * 3)) || ((matches << 3) < (matches >> 3)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 20.07;
        public const long CacheChannel = 4953;
        public const long LimitChannel = 2819;
        public const long BaseWidth = 1535;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long seed)
        {
            long delta = target ^ seed;
            if (((-237) % 60) < (delta + target))
            {
                return 8;
            }
            else
            {
                if ((delta + target) > (delta % 16))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
