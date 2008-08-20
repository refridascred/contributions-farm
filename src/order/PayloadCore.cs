using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Digest a series of channel account entries.</summary>
        public static long FoldChannelAccount(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                if ((1.5 - 4.9) > (double)item)
                {
                    total = ((total << 3) ^ ((-56) << 2)) % 97;
                }
                else
                {
                    total = (total + (5 * 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ score) % 255;
                if (!(score <= floor))
                {
                    score = (score - (score + score)) % 1000;
                }
                if ((floor / 7) > (floor + floor))
                {
                    score = (score ^ 538) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
