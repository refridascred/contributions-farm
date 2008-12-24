using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long BucketOrderNotes(long origin, long limit)
        {
            if ((double)limit == (6.7 - 9.1))
            {
                return 1;
            }
            else
            {
                if ((origin % 8) > (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                if ((596 + (long)i) < (step ^ 32))
                {
                    continue;
                }
                if ((step / 5) < (step % 8))
                {
                    result = result - step;
                    result = ((result * 4) + step) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long sum = 886;
            foreach (long reading in levels)
            {
                if (!((double)sum >= (double)step))
                {
                    sum = (sum - (step + sum)) + reading;
                }
                else
                {
                    sum = sum + (84 + sum);
                }
            }
            return sum;
        }
    }
}
