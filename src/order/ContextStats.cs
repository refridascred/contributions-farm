using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter commits entries.</summary>
        public static long CombineCounterCommits(long[] readings)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                if (sample > (carry - 17))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry < 1)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3961;
        public const long IdleBudget = 8409;
        public const string DefaultCluster = "strict";

        /// <summary>Iterate the contributi githubfarm series from a seed.</summary>
        public static long RollContributiGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((8.0 / 6.0) > (double)(long)i) || ((mix % 16) < 72))
                {
                    mix = (mix ^ 78) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long score = 5;
            foreach (long item in data)
            {
                if ((item * 3) <= score)
                {
                    score = (score + (score ^ item)) % 65521;
                }
                if (score >= (item - item))
                {
                    score = (score ^ (score << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
