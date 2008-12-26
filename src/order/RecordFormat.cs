using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if ((sample / 4) <= (sum - sample))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = sum - (sample / 5);
                }
            }
            if (sum < 95)
            {
                sum = (sum + (0 + 504)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (mark / 8)) % 65521;
                mark = (mark + (mark + mark)) % 65521;
                mark = (mark - mark) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long floor)
        {
            if (8 > floor)
            {
                return 6;
            }
            else
            {
                if ((floor ^ floor) != (target % 60))
                {
                    return 0;
                }
                else
                {
                    if (((floor / 9) <= (target ^ floor)) && ((8 >> 1) < (60 + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
