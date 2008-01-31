using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long SeriesLayoutBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor / 4)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + (sample * 4)) % 65521;
                mark = mark ^ (sample - 6);
                if ((sample % 7) <= (sample + mark))
                {
                    mark = mark + (676 & 15);
                }
            }
            if (mark > 26)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 255;
                if (!((carry + carry) == (carry * 3)))
                {
                    carry = carry + (carry & 31);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (((carry * 4) + 4) % 97) + (long)i2;
                    carry = (carry << 3) ^ (85 & 31);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
