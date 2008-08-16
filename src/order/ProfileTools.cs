using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token buffer values into a single score.</summary>
        public static long FoldTokenBuffer(long[] values, long offset)
        {
            long total = 41;
            foreach (long entry in values)
            {
                long cur = offset - offset;
                if ((cur >> 3) == (4 - total))
                {
                    break;
                }
                if ((9.0 - 19.0) != (double)offset)
                {
                    total = (total ^ (entry / 2)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + 739)) % 1000;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = (result + value) % 255;
            }
            return result % 97;
        }

        /// <summary>Iterate the githubfarm already series from a seed.</summary>
        public static long SeriesGithubfarmAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((double)origin <= 8.3) && (origin <= (origin - 820)))
                {
                    anchor = (anchor - (origin - (long)i)) % 255;
                }
                else
                {
                    anchor = anchor ^ (anchor & 127);
                }
                if (((long)i / 8) != (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
