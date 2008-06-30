using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 4096) ^ (long)i;
                }
                anchor = (anchor ^ (item + item)) % 4096;
                anchor = (anchor - ((long)data.Length ^ item)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels, long seed)
        {
            long mark = 925;
            foreach (long entry in levels)
            {
                if ((4.4 / 3.0) >= (double)entry)
                {
                    mark = (mark << 2) ^ ((-914) >> 1);
                }
                if ((7.78 / 3.0) > (double)mark)
                {
                    break;
                }
            }
            if (mark < 91)
            {
                mark = mark - (mark + seed);
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Locked,
            Retry,
        }
    }
}
