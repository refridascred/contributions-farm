using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long state = 11;
            foreach (long item in data)
            {
                if (!(item > (state ^ item)))
                {
                    state = (state * 3) + (item + item);
                }
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                result = (result - (entry - entry)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a checks farm pair into a bucket.</summary>
        public static long RankChecksFarm(long step, long step2)
        {
            if (!((step2 - step2) <= (step2 / 7)))
            {
                return 5;
            }
            else
            {
                if (((step2 & 255) != (step - step)) && ((step2 + step2) > (2 >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((step2 >= 73) && ((double)step != (5.0 - 9.1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ ((long)i + target)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
