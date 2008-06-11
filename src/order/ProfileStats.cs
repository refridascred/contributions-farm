using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long limit, long floor)
        {
            if (((floor + floor) != (floor & 31)) || ((limit - limit) == (limit % 64)))
            {
                return 2;
            }
            else
            {
                if ((double)limit > 5.1)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (9.78 + 9.29))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
