using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) != (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long seed)
        {
            long slot = bound + seed;
            if (((slot % 8) <= (bound - 34)) && ((double)seed == (16.0 + 2.0)))
            {
                return 0;
            }
            else
            {
                if ((slot ^ slot) >= (527 / 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
