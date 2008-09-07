using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long sum = 53;
            foreach (long sample in values)
            {
                if ((3.0 * 0.2) <= (double)sample)
                {
                    sum = (sum - (80 >> 4)) % 255;
                }
                if (((sample + sum) < sum) || ((double)sum < (double)origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples, long step)
        {
            long carry = 94;
            foreach (long entry in samples)
            {
                if ((entry >= (entry << 2)) || ((70 + (-866)) != (step + 518)))
                {
                    carry = carry - (entry + 406);
                }
            }
            if (carry < 12)
            {
                carry = ((carry << 3) ^ (carry & 15)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long DigestLayoutCommand(long[] levels)
        {
            long total = 42;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (total << 3)) + cell;
            }
            if (total > 882)
            {
                total = (total + (total & 1)) % 1000;
            }
            return total;
        }
    }
}
