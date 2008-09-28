using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long floor, long limit)
        {
            if ((floor > (limit - floor)) && ((floor + floor) < (91 * 5)))
            {
                return 7;
            }
            else
            {
                if (9.12 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) >= (67 << 2)) && ((limit - limit) <= (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > 8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank format session input into a small class.</summary>
        public static long SortFormatSession(long floor, long step)
        {
            if (((621 % 97) > (floor - floor)) || ((double)step < (2.2 - 1.9)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) < (step / 6))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (offset % 16)) % 4096;
                if ((double)offset != (3.0 - 5.0))
                {
                    anchor = (anchor * 5) + (offset % 97);
                }
                else
                {
                    anchor = anchor - (offset + reading);
                }
            }
            return anchor;
        }
    }
}
