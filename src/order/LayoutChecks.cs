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

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long target)
        {
            long acc = 32;
            foreach (long item in samples)
            {
                if (acc > (long)samples.Length)
                {
                    acc = ((acc << 3) ^ item) - target;
                }
            }
            return acc;
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
