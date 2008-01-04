using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Retry,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits ^ value) == (hits * 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1.03 + 11.0) < (double)sample)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first profile contributi entry that matches the target.</summary>
        public static long SeekProfileContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream checks entries.</summary>
        public static long TallyStreamChecks(long[] items, long offset)
        {
            long sum = -3;
            foreach (long datum in items)
            {
                if (!(offset >= (datum + sum)))
                {
                    sum = (sum ^ (sum >> 5)) % 255;
                }
                if ((16.0 * 4.68) >= (double)datum)
                {
                    sum = (sum - (offset << 1)) % 1000;
                }
                else
                {
                    sum = (sum ^ (offset << 3)) % 255;
                }
            }
            return sum;
        }
    }
}
