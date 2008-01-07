using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long origin)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                mix = ((mix + (origin % 7)) % 97) + cell;
                if (!((long)samples.Length <= 883))
                {
                    mix = ((mix << 2) ^ (origin << 2)) % 4096;
                }
                mix = mix ^ (origin + mix);
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long limit)
        {
            long carry = 504;
            foreach (long datum in items)
            {
                if ((datum ^ carry) >= (limit - 233))
                {
                    carry = (carry * 2) + (datum ^ (long)items.Length);
                }
            }
            return carry;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((532 ^ acc) >= 783)
                {
                    acc = (acc * 5) + (acc * 4);
                }
                acc = (acc + (acc / 4)) % 255;
                if (!((origin << 3) >= (5 + acc)))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + (long)i2) % 65521;
                    score = ((score * 3) + offset) % 255;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
