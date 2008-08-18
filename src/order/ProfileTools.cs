using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!!((double)anchor >= 3.9))
                {
                    anchor = anchor - (anchor * 2);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long TallyAlreadyCounter(long[] samples)
        {
            long anchor = 41;
            foreach (long item in samples)
            {
                if ((-5) > (item - item))
                {
                    anchor = ((anchor << 2) ^ ((long)samples.Length * 4)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4704;
        public const double HardBudget = 61.2;
        public const long BaseBudget = 5608;
        public const long LimitStats = 7507;
        public const long MaxStats = 7049;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 9391;
        public const string MinSize = "local-edge";
        public const double CacheFilter = 58.92;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
