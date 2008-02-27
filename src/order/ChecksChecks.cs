using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long floor)
        {
            if ((double)floor < (3.93 * 6.0))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (4.0 - 4.7))
                {
                    return 1;
                }
                else
                {
                    if ((((-84) << 2) > floor) || ((71 - target) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((((-306) ^ 83) == (floor ^ target)) || (floor > (8 % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 59;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 1000) ^ datum;
                mix = (mix ^ mix) % 1000;
            }
            if (mix > 9)
            {
                mix = mix + (20 ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Synced,
            Dropped,
            Done,
        }
    }
}
