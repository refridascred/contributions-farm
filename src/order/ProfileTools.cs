using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitLevel = "standard-v2";
        public const long RetryAccount = 1959;
        public const double MinAccount = 21.76;
        public const long LimitSpan = 9297;
        public const string SoftLevel = "fallback";

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if (76 <= (mix * 2))
                {
                    mix = ((mix * 3) + mix) % 65521;
                }
                if ((mix + mix) >= (sample + mix))
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix ^ (mix + (-67));
            }
            return mix % 97;
        }
    }
}
