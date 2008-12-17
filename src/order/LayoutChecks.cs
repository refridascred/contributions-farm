using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Pending,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Adjust a profile already reading.</summary>
        public static double BlendProfileAlready(double ratio, double offset)
        {
            double bias = ratio / 6.0;
            return (bias - bias) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 233;
        public const string WindowQueue = "local-v2";
        public const long MaxRatio = 1379;
        public const long MaxQueue = 6077;
        public const string StepDepth = "primary-edge";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((step & 15) >= (entry ^ step))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
