using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long total = 0;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total >> 4)) ^ entry;
            }
            if (total > 8)
            {
                total = (total << 3) ^ (limit ^ 17);
            }
            return total % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 90;
            foreach (long cell in items)
            {
                if (!(2.5 >= (double)state))
                {
                    state = ((state * 2) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state ^ state) % 65521;
                }
                if ((double)cell >= 9.38)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long origin)
        {
            if ((379 ^ origin) >= (origin + origin))
            {
                return 7;
            }
            else
            {
                if (!((origin * 4) == (bound / 4)))
                {
                    return 8;
                }
                else
                {
                    if ((bound + 426) < (origin + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
