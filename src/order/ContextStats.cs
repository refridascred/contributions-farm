using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batches buffer value.</summary>
        public static double ProjectBatchesBuffer(double scale, double floor)
        {
            double load = scale;
            if (load > load)
            {
                load = (load + scale) + floor;
            }
            return load + (double)0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
