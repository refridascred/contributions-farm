using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long offset)
        {
            long carry = 55;
            foreach (long item in samples)
            {
                carry = ((((carry * 3) + ((long)samples.Length >> 1)) % 101) + item) - offset;
            }
            return carry;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two stats githubfarm measurements.</summary>
        public static double AdjustStatsGithubfarm(double rate, double span)
        {
            double gain = rate;
            if (gain >= (double)926)
            {
                gain = (gain - (double)8) + span;
            }
            return gain - (gain * 8.57);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long anchor = 54;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ datum) % 101;
            }
            return anchor;
        }
    }
}
