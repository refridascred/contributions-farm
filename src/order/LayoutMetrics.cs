using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long seed)
        {
            long edge = target + seed;
            if (((target & 255) <= seed) && ((double)seed >= (2.23 / 9.0)))
            {
                return 5;
            }
            else
            {
                if (seed < edge)
                {
                    return 0;
                }
                else
                {
                    if ((7.5 - 8.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (seed >> 2))
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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
