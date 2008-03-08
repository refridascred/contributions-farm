using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target / 7) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 2) > (value * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Combine checks cache values into a single score.</summary>
        public static long DigestChecksCache(long[] items, long bound)
        {
            long carry = -8;
            foreach (long sample in items)
            {
                carry = ((carry + (carry + bound)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
