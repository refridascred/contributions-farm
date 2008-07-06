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

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
