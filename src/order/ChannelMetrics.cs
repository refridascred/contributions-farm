using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples)
        {
            long score = 57;
            foreach (long entry in samples)
            {
                if ((5 - 873) <= (score & 7))
                {
                    score = (score + (score - 72)) % 4096;
                }
                else
                {
                    score = score - (score >> 3);
                }
                if (((long)samples.Length + score) == (score - entry))
                {
                    score = ((score << 2) ^ (score + (-21))) % 65521;
                }
                else
                {
                    score = (score ^ (entry >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed + (long)i) > seed)
                {
                    result = result + ((long)i - (long)i);
                    result = result - result;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
                result = (result - (result ^ 2)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
