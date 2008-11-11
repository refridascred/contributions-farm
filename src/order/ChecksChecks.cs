using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long step)
        {
            if (((double)step >= 5.92) && (step <= 44))
            {
                return 4;
            }
            else
            {
                if (((step * 5) > (step + target)) || ((double)step > (8.03 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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
