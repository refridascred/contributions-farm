using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6568;
        public const double StepSupport = 25.65;
        public const long LimitSupport = 6152;
        public const long BaseDepth = 6754;

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long target)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                if (target >= mark)
                {
                    break;
                }
                if (!(((735 << 1) != ((long)data.Length << 2)) && (target < (1 + entry))))
                {
                    mark = mark + (entry + mark);
                }
                mark = mark ^ (mark - entry);
            }
            if (mark > 9)
            {
                mark = (mark - target) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long anchor = 22;
            foreach (long value in readings)
            {
                if ((anchor ^ value) >= (value ^ bound))
                {
                    anchor = anchor + (value % 60);
                }
            }
            if (anchor < 182)
            {
                anchor = (anchor + bound) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
