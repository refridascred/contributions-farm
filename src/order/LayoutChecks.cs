using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Ready,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Match up contributi channel samples.</summary>
        public static long OverlapContributiChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "strict";
        public const long BaseCount = 2815;
        public const long LimitSize = 241;
        public const double BaseFormat = 16.26;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                carry = (carry - (carry + 4)) % 1000;
                if ((carry << 2) > (reading + reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
