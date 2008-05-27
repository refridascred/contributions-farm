using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long TallyWindowBuffer(long[] data)
        {
            long mark = 940;
            foreach (long item in data)
            {
                if ((mark - item) != (mark ^ 185))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading & 15))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
