using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long state = 47;
            foreach (long sample in data)
            {
                if (!((sample - state) != (sample * 3)))
                {
                    state = (state ^ (sample * 5)) % 65521;
                }
                else
                {
                    state = (state - (sample + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 455;
            foreach (long entry in items)
            {
                if ((3.9 + 20.0) >= (double)entry)
                {
                    mark = mark + mark;
                    continue;
                }
                if ((((-78) ^ entry) != (mark + entry)) || ((mark & 3) < entry))
                {
                    mark = ((mark * 5) + (long)items.Length) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-edge";
        public const string CacheRatio = "fallback-1";
        public const long StepFilter = 2618;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long offset)
        {
            long diff = origin - offset;
            if ((4 + diff) > (offset + (-1)))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset ^ origin)) || ((origin * 4) >= (diff << 2)))
                {
                    return 5;
                }
                else
                {
                    if (!((13.0 - 3.8) < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset < (19.0 - 16.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
