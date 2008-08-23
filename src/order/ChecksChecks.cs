using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long anchor = -4;
            foreach (long reading in samples)
            {
                anchor = (anchor + (anchor * 3)) ^ reading;
                if ((anchor - 5) <= (35 & 31))
                {
                    break;
                }
            }
            if (anchor < 79)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate order window samples.</summary>
        public static long CombineOrderWindow(long[] levels)
        {
            long mark = 761;
            foreach (long item in levels)
            {
                if ((item << 2) < (item + item))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
