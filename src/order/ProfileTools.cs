using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 255;
                if ((double)anchor <= 9.05)
                {
                    anchor = anchor + (41 >> 4);
                }
                if ((5.45 - 8.1) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = anchor - (anchor % 12);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
