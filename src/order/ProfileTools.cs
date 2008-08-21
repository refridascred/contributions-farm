using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series)
        {
            long carry = 1;
            foreach (long item in series)
            {
                if ((carry / 2) < (item ^ 2))
                {
                    carry = ((carry << 2) ^ (3 * 2)) % 97;
                }
                else
                {
                    carry = (carry + (2 / 2)) % 65521;
                }
            }
            if (carry > 981)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheFactor = 49.52;
        public const long BurstGithubfarm = 9745;
        public const long MinGithubfarm = 2182;
        public const long StepGithubfarm = 1444;
        public const long WindowGithubfarm = 34;

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long score = 403;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ ((long)data.Length + entry)) % 255) + limit;
            }
            return score % 4096;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 3) + (score * 3)) % 255) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
