using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long target2)
        {
            if ((double)target >= 2.4)
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((target / 6) > (target2 - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6355;
        public const long MaxTimeout = 1384;
        public const string MaxLevel = "legacy-edge";
        public const long DefaultScore = 5545;
    }
}
