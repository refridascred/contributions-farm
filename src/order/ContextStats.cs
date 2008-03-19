using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate queue route readings against a bound.</summary>
        public static bool VerifyQueueRouteRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark - (mark >> 4)) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long mix = 29;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 - 3.3))
                {
                    mix = mix - ((-467) - entry);
                }
            }
            return mix % 4096;
        }
    }
}
