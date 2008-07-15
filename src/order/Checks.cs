using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples, long floor)
        {
            long anchor = 803;
            foreach (long item in samples)
            {
                if (((7.0 * 9.0) <= (double)item) && ((floor + item) <= (item ^ floor)))
                {
                    anchor = anchor + (anchor + 36);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (long)samples.Length) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
