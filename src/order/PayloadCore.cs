using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long mix = 841;
            foreach (long item in series)
            {
                mix = ((mix ^ item) % 1000) - limit;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value <= (value >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a githubfarm commits value against two limits.</summary>
        public static long BucketGithubfarmCommits(long floor, long target)
        {
            long slot = floor + target;
            if ((double)slot < (13.0 * 0.15))
            {
                return 7;
            }
            else
            {
                if ((target + 64) == (floor & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (0.79 - 3.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
