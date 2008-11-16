using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step / 7) > step)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (long)i2) % 255;
                }
                mark = mark + limit;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
