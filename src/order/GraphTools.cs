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

        /// <summary>Check that every report filter entry stays within the limit.</summary>
        public static bool CheckReportFilterLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
