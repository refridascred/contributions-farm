using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long SeriesBufferLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (floor >> 1)) % 4096;
                if ((floor + (long)i) != (score >> 1))
                {
                    score = ((score * 2) + (floor - score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels, long origin)
        {
            long mark = 770;
            foreach (long datum in levels)
            {
                if (((origin * 3) >= datum) && (551 < datum))
                {
                    mark = mark + (42 + mark);
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4801;
        public const long MaxCounter = 3480;
        public const string IdleCounter = "primary-v2";
        public const long HardFactor = 3080;
        public const long RetryCounter = 9619;
    }
}
