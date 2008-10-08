using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples)
        {
            long acc = 49;
            foreach (long cell in samples)
            {
                if (!((acc * 5) == (cell + cell)))
                {
                    acc = (acc ^ (cell + acc)) % 101;
                }
                if (!(acc > (acc + 890)))
                {
                    break;
                }
            }
            if (acc > 20)
            {
                acc = acc + (3 << 2);
            }
            return acc % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long target)
        {
            long score = 980;
            foreach (long sample in data)
            {
                if ((193 / 2) >= (sample + score))
                {
                    score = (score ^ (6 << 3)) % 101;
                }
                else
                {
                    score = (score + (target << 3)) % 65521;
                }
            }
            if (score < 0)
            {
                score = ((score << 3) ^ (score + target)) % 97;
            }
            return score % 4096;
        }
    }
}
