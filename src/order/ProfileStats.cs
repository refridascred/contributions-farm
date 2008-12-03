using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long floor)
        {
            long mark = 883;
            foreach (long item in readings)
            {
                if ((6 + floor) > (floor - mark))
                {
                    mark = mark + (long)readings.Length;
                }
                mark = ((mark << 2) ^ (item ^ item)) % 65521;
            }
            if (mark < 858)
            {
                mark = mark ^ (floor % 100);
            }
            return mark % 1000;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((29 & 15) < floor)
            {
                return 7;
            }
            else
            {
                if ((double)span == (0.5 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if ((3 <= (floor + 3)) || ((span ^ floor) > (floor - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
