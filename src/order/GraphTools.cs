using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long mix = 873;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix << 3) ^ ((long)i >> 5)) % 97;
                }
                if ((double)(long)samples.Length != (3.8 * 16.0))
                {
                    continue;
                }
                else
                {
                    mix = (mix * 2) + step;
                }
                mix = ((mix << 3) ^ (step + sample)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 77;
            foreach (long reading in values)
            {
                if ((5.8 / 6.0) > (double)reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (reading ^ sum);
                }
            }
            if (sum < 43)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Idle,
            Done,
            Active,
            Pending,
        }
    }
}
