using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((long)i + target)) % 97;
                score = score ^ (target * 2);
                score = (score << 3) ^ (target + target);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long carry = 36;
            foreach (long cell in values)
            {
                carry = ((carry - carry) % 1000) ^ cell;
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long limit, long offset)
        {
            if ((offset << 2) <= offset)
            {
                return 2;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset + 906) >= ((-322) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit <= (9.25 / 6.0))
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
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 1830;
        public const long WindowRoute = 7685;
        public const long CacheRoute = 802;
    }
}
