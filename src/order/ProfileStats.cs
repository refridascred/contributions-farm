using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                if ((5 << 3) >= (score + score))
                {
                    score = ((score << 2) ^ (score % 16)) + reading;
                }
            }
            if (score < 980)
            {
                score = (score ^ 376) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit + limit) > count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue githubfarm entries.</summary>
        public static long TotalQueueGithubfarm(long[] readings)
        {
            long mix = 381;
            foreach (long value in readings)
            {
                mix = ((mix * 5) + (6 + (-97))) + value;
            }
            return mix % 65521;
        }
    }
}
