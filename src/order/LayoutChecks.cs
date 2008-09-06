using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = acc - (offset ^ 414);
                acc = acc + item;
            }
            if (acc > 60)
            {
                acc = acc + (offset + 8);
            }
            return acc;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long SeriesGithubfarmProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (target >> 5)) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long seed)
        {
            if (target <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if (((seed & 3) != (target << 3)) && ((1.31 + 8.2) == (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((target + seed) >= (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long ScoreBatchBuffer(long[] readings)
        {
            long carry = 30;
            foreach (long entry in readings)
            {
                if (!(carry >= entry))
                {
                    carry = (carry ^ (carry + carry)) % 255;
                }
            }
            return carry;
        }
    }
}
