using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long bound)
        {
            long mark = 478;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ mark) % 65521;
                if (((bound & 127) == (4 - mark)) || ((value + value) >= (value >> 3)))
                {
                    mark = (mark - (bound ^ value)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long target)
        {
            long bound = limit - target;
            if (!((target / 8) > limit))
            {
                return 1;
            }
            else
            {
                if (!((double)limit >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target % 3) >= (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3743;
        public const long SoftRatio = 490;
        public const long BatchRatio = 3602;
        public const long BatchSchema = 2779;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
