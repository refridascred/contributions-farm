using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long score = 4;
            foreach (long cell in items)
            {
                score = (score << 2) ^ (score + cell);
            }
            if (score > 566)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples, long offset)
        {
            long sum = 66;
            foreach (long reading in samples)
            {
                if ((offset >= reading) || ((offset % 60) >= (605 / 5)))
                {
                    sum = (sum + (offset + offset)) % 97;
                }
                else
                {
                    sum = sum - (980 ^ 181);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Queued,
            Retry,
            Draft,
        }
    }
}
