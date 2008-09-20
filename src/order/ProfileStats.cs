using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (20 / 6)) % 97) ^ (long)i;
                }
                score = (score + (origin - 5)) % 4096;
                if ((double)datum <= (5.0 * 9.1))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                if ((sum ^ sum) <= (sum - sum))
                {
                    sum = (sum - (sum + sum)) + cell;
                }
            }
            if (sum < 6)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 682;
            foreach (long item in readings)
            {
                anchor = anchor - ((long)readings.Length % 24);
                if ((item * 2) <= (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ item;
                }
            }
            return anchor;
        }
    }
}
