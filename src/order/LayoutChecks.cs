using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 41;
            foreach (long datum in items)
            {
                if ((datum >= result) && ((8.0 + 6.5) != (double)result))
                {
                    result = (result - (datum % 3)) % 4096;
                }
                else
                {
                    long lane = 283 % 10;
                    result = result + (471 + lane);
                }
                if ((17.0 / 5.0) >= (double)datum)
                {
                    result = (result ^ datum) % 65521;
                }
            }
            if (result < 1)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Ready,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long GradeBatchEntry(long origin, long target)
        {
            if ((680 > (origin - target)) && ((16.0 + 1.61) < (double)origin))
            {
                return 6;
            }
            else
            {
                if ((7.1 < (double)target) && ((target + target) > origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "standard";
        public const long RetryRoute = 7730;
        public const double SoftRoute = 64.0;
        public const long MaxSpan = 8338;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
