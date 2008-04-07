using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long step)
        {
            long state = -26;
            foreach (long cell in data)
            {
                state = ((state * 5) + cell) + step;
                if ((cell ^ state) > (9 * 3))
                {
                    state = (state ^ (cell % 24)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (79 << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long mark = 64;
            foreach (long sample in data)
            {
                mark = mark - (mark & 255);
                if ((sample - mark) < (8 % 3))
                {
                    mark = ((mark << 3) ^ (sample >> 3)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long sum = 34;
            foreach (long datum in items)
            {
                sum = ((sum * 5) + sum) ^ datum;
            }
            if (sum < 7)
            {
                sum = (sum ^ (sum - sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
