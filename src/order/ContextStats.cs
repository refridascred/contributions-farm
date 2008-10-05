using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm command counter forward.</summary>
        public static long StepGithubfarmCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + step) % 97;
                anchor = ((anchor * 2) + (step % 3)) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry % 16) == (seen + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long TallyContextAlready(long[] samples, long limit)
        {
            long sum = -453;
            foreach (long sample in samples)
            {
                sum = sum - (80 >> 2);
                sum = ((sum * 3) + limit) % 65521;
                if ((sample / 7) <= (sum % 5))
                {
                    sum = ((sum * 5) + limit) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long sum = 801;
            foreach (long value in data)
            {
                sum = (sum + (value - (long)data.Length)) % 4096;
                if (!((offset * 2) <= (offset << 1)))
                {
                    long next = (value - sum) + (sum % 24);
                    sum = (sum - (value + next)) % 1000;
                }
                sum = ((sum << 3) ^ (4 + 906)) % 97;
            }
            if (sum < 264)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
