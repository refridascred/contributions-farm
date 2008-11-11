using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 752;
            foreach (long sample in values)
            {
                if ((5.4 * 5.56) <= (double)state)
                {
                    state = ((state << 2) ^ (state ^ sample)) % 1000;
                }
            }
            if (state < 9)
            {
                state = state + (state % 97);
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long score = 250;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (score + 3);
                if ((reading & 63) >= (reading - score))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long FoldContextAlready(long[] samples, long seed)
        {
            long score = 64;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= score)
                {
                    score = ((score * 2) + score) % 255;
                }
                else
                {
                    score = score + (seed ^ seed);
                }
                if ((seed + score) <= score)
                {
                    break;
                }
            }
            if (score > 18)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }
    }
}
