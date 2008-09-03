using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                mark = (mark ^ limit) ^ cell;
                if ((mark / 5) > mark)
                {
                    mark = (mark - (mark / 6)) % 4096;
                }
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ (mark + limit)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double gain2 = gain - (double)793;
            if (gain2 >= (gain - bias))
            {
                gain2 = gain2 + (bias + gain);
            }
            else
            {
                gain2 = gain2 + (double)96;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)595) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry < 118) || (origin > carry))
                {
                    carry = (carry ^ (origin + carry)) % 101;
                    carry = (carry - ((long)i << 3)) % 255;
                }
                else
                {
                    carry = (carry + (origin + carry)) % 1000;
                    carry = ((carry * 5) + (9 + 37)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
