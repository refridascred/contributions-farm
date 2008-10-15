using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long bound, long offset)
        {
            if ((offset % 3) > (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((bound + 81) == (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if ((417 ^ offset) != (offset & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound % 16) != (bound / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
