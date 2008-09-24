using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (reading - seen))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data, long offset)
        {
            long acc = 400;
            foreach (long sample in data)
            {
                acc = (((acc << 3) ^ (sample - sample)) % 255) + offset;
            }
            return acc;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Retry,
            Ready,
        }
    }
}
