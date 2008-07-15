using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstRatio = 1727;
        public const string BurstBatch = "local-v2";
        public const long SoftBatch = 4369;

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
