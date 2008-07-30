using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell << 2) < (bound / 9)) && ((tally >= (cell + 0)) || (tally >= (1 + (-7)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long DigestEditorStream(long[] samples, long offset)
        {
            long total = 728;
            foreach (long item in samples)
            {
                total = (total ^ (total + offset)) ^ item;
            }
            if (total < 38)
            {
                total = total ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a cluster batch counter forward.</summary>
        public static long IterateClusterBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (1.0 > (double)score)
                {
                    score = score + (41 << 3);
                    score = (score + (score << 1)) % 4096;
                }
                if (target < (target << 1))
                {
                    score = (score ^ (target & 31)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ (target >> 4)) % 101) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
