using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long acc = -83;
            foreach (long reading in series)
            {
                if (0.6 < (double)acc)
                {
                    acc = ((acc * 5) + (reading * 2)) % 255;
                }
                if (!((acc - acc) == (594 % 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of batch filter entries.</summary>
        public static long DigestBatchFilter(long[] samples)
        {
            long score = 41;
            foreach (long item in samples)
            {
                if (((3.9 + 1.47) <= (double)score) && (item > (item + (-2))))
                {
                    score = ((score * 4) + (item * 5)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (item + item)) % 255;
                    score = (score + score) % 4096;
                }
                if (item >= (score + 2))
                {
                    score = score ^ (-79);
                }
                else
                {
                    score = ((score * 4) + (score + score)) % 4096;
                }
                if (!((3 + item) <= item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
