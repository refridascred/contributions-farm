using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((711 - offset) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            New,
            Locked,
            Paused,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples)
        {
            long anchor = 354;
            foreach (long entry in samples)
            {
                if ((entry ^ (long)samples.Length) >= (entry + entry))
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
