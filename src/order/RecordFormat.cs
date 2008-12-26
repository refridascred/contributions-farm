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

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long target)
        {
            if ((target ^ floor) < (target * 5))
            {
                return 3;
            }
            else
            {
                if ((target + (-84)) < floor)
                {
                    return 0;
                }
                else
                {
                    if (!((floor << 2) <= (7 >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                long bound = (floor % 3) ^ mark;
                if (((bound - (long)i) > (floor << 1)) && ((double)mark < 5.1))
                {
                    mark = ((mark * 4) + (floor + floor)) % 101;
                    bound = ((bound * 5) + mark) % 101;
                    break;
                }
                else
                {
                    mark = (mark * 5) + (mark + mark);
                    bound = ((bound << 2) ^ bound) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
