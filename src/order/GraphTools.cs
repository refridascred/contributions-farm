using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long seed)
        {
            long result = 299;
            foreach (long item in items)
            {
                if (!(result > (seed + seed)))
                {
                    result = (result ^ (64 + result)) ^ item;
                }
            }
            return result;
        }

        /// <summary>Grade a support notes value against two limits.</summary>
        public static long SortSupportNotes(long offset, long bound)
        {
            long diff = offset + bound;
            if (((double)bound > (7.0 * 0.1)) && (offset >= (diff ^ diff)))
            {
                return 5;
            }
            else
            {
                if ((offset ^ offset) > diff)
                {
                    return 7;
                }
                else
                {
                    if (((0 - bound) <= (diff * 4)) || (bound > (bound + diff)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset << 3) != (offset * 2)) || ((bound * 5) <= (3 - bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long origin)
        {
            long bound = target + origin;
            if (target < (target - target))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > (21 ^ 186))
                {
                    return 5;
                }
                else
                {
                    if (target < (origin * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 6) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
