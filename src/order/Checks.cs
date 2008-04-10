using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long mix = 98;
            foreach (long entry in samples)
            {
                if ((9 - 51) >= mix)
                {
                    mix = ((mix ^ (step + 9)) % 255) - entry;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of filter graph entries.</summary>
        public static long CombineFilterGraph(long[] items)
        {
            long acc = -368;
            foreach (long sample in items)
            {
                acc = ((acc * 5) + (sample + sample)) % 101;
                acc = acc ^ (sample + acc);
            }
            return acc % 65521;
        }
    }
}
