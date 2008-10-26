using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long target)
        {
            long delta = offset - target;
            if (((target ^ delta) <= (offset & 3)) && ((delta + 163) > offset))
            {
                return 6;
            }
            else
            {
                if (((5.0 * 7.7) > (double)offset) || ((delta & 63) != (offset % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (20.0 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 3) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3290;
        public const double SoftBuffer = 17.64;
        public const double StepTimeout = 63.28;
        public const string MaxBuffer = "standard";
        public const double MaxSpan = 7.55;

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 71;
            foreach (long datum in series)
            {
                if ((total + datum) > (datum ^ datum))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total * 5) + (total * 4)) % 101;
                }
                if ((double)datum <= (1.0 * 4.6))
                {
                    total = (total - datum) % 255;
                }
                else
                {
                    total = total ^ (datum << 3);
                }
            }
            return total;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
