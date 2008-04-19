using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up session notes samples.</summary>
        public static long CompareSessionNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long target)
        {
            if (((target - seed) < (target - target)) || ((double)seed >= (3.8 / 7.0)))
            {
                return 1;
            }
            else
            {
                if (599 < (target + target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((step << 1) <= ((long)levels.Length + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 814;
            foreach (long reading in values)
            {
                if (!((reading - 72) >= (7 << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 4096;
                }
            }
            if (total > 41)
            {
                total = total + (total + 516);
            }
            return total;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Pending,
            Dropped,
        }
    }
}
