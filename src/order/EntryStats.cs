using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            if ((3 ^ 71) <= seed)
            {
                return 5;
            }
            else
            {
                if (!((7.0 - 1.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((12 + offset) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(item >= (offset * 4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long TotalSchemaChannel(long[] items, long seed)
        {
            long anchor = -5;
            foreach (long item in items)
            {
                anchor = (anchor + (anchor + 5)) % 101;
                if (item <= (item + seed))
                {
                    anchor = (anchor - (seed + anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
