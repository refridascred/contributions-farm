using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long sum = 5;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 1000;
                if (sum >= (target + target))
                {
                    sum = (sum - target) % 255;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ target) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                if ((score * 5) == (step - (long)i))
                {
                    score = score + (604 + 6);
                    score = score + (score + step);
                }
                else
                {
                    score = (score ^ (step + step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
