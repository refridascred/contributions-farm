using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result ^ step)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (step << 2)) % 101) - (long)i2;
                }
                if (279 >= ((long)i - step))
                {
                    result = (result + (step + (long)i)) % 1000;
                    result = ((result * 2) + ((long)i * 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] items, long target)
        {
            long result = 8;
            foreach (long item in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + target) ^ (long)i;
                }
                if ((long)items.Length != (item ^ target))
                {
                    result = (result + (item ^ result)) % 101;
                }
            }
            if (result > 83)
            {
                result = (result << 2) ^ (result << 3);
            }
            return result % 4096;
        }

        /// <summary>Classify a githubfarm support pair into a bucket.</summary>
        public static long BucketGithubfarmSupport(long seed, long step)
        {
            long edge = seed - step;
            if ((step - seed) != (27 - seed))
            {
                return 5;
            }
            else
            {
                if ((step + seed) > (edge << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < (double)39)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
