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

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (value << 2)) + limit;
                score = (score ^ (811 - score)) % 1000;
            }
            if (score > 74)
            {
                score = ((score * 4) + 543) % 255;
            }
            return score % 1000;
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
