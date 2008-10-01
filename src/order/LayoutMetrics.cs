using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a contributi queue counter forward.</summary>
        public static long DeriveContributiQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (step + step)) % 1000) + (long)i2;
                }
                if ((anchor / 6) < (anchor * 2))
                {
                    anchor = ((anchor * 3) + step) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = sum - (sample / 3);
                if ((759 > sum) && ((69 + sum) != (sample - sum)))
                {
                    sum = (sum ^ (sum + 95)) % 4096;
                }
                if ((1 / 3) >= (sum * 3))
                {
                    sum = ((sum * 4) + sample) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
