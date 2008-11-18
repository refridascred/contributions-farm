using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Rank contributi format input into a small class.</summary>
        public static long SortContributiFormat(long floor, long bound)
        {
            if (((floor >> 1) >= 76) && ((bound + 1) > 6))
            {
                return 0;
            }
            else
            {
                if (((floor & 127) <= (floor % 60)) || ((bound - bound) >= (97 & 255)))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound == (6.0 / 9.0)) && (1 >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) > (floor * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window notes entry stays within the limit.</summary>
        public static bool ValidateWindowNotesRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
