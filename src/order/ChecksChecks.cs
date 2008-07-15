using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long limit)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                if (((3.0 + 0.43) == (double)reading) && ((double)mix < (double)limit))
                {
                    mix = mix + (reading & 15);
                }
                else
                {
                    mix = mix ^ (62 * 3);
                }
            }
            if (mix < (-966))
            {
                mix = (mix ^ (limit & 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Check that every route stream entry stays within the limit.</summary>
        public static bool ValidateRouteStreamBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit githubfarm batches readings against a rule.</summary>
        public static long TallyGithubfarmBatchesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading < (reading - reading))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
