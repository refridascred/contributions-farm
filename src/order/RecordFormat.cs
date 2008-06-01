using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long mark = 586;
            foreach (long cell in data)
            {
                if (((cell << 1) != (19 & 63)) || (cell < (mark - cell)))
                {
                    mark = (mark ^ (mark + cell)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Locked,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long target)
        {
            long bound = limit + target;
            if (((-917) ^ bound) > (577 ^ 934))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 8) != (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((mix / 8) != (mix - mix))
                {
                    mix = mix ^ ((-70) - mix);
                    mix = ((mix * 3) + mix) % 97;
                }
                if ((entry & 7) <= (mix >> 1))
                {
                    mix = (mix + (entry + entry)) % 97;
                }
                else
                {
                    mix = (mix ^ (entry - mix)) % 65521;
                }
                if ((mix >= (entry & 7)) && ((long)samples.Length < mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
