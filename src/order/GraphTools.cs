using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 447;
            foreach (long item in series)
            {
                if ((item ^ item) <= total)
                {
                    total = ((total << 2) ^ (94 + 587)) % 4096;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window token entries.</summary>
        public static long WeighWindowToken(long[] data, long bound)
        {
            long mark = 1;
            foreach (long item in data)
            {
                if ((item - item) <= (item - 24))
                {
                    mark = ((mark * 2) + (bound << 3)) % 255;
                }
                mark = (mark - (item >> 3)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (step * 2)) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Locked,
            Pending,
        }
    }
}
