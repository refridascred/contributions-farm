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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Rank { get; set; }
            public double Token { get; set; }
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length <= (31 - (-56)))
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
            }
            return seen;
        }
    }
}
