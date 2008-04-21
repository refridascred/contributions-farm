using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine schema record values into a single score.</summary>
        public static long CombineSchemaRecord(long[] data)
        {
            long carry = 387;
            foreach (long sample in data)
            {
                carry = (carry + (carry / 5)) ^ sample;
            }
            if (carry < 98)
            {
                carry = (carry - (carry ^ 89)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long limit)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ cell) % 1000;
            }
            if (result > 196)
            {
                result = result - (limit & 63);
            }
            return result;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 5) <= (7 >> 4))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Stale,
            New,
            Queued,
        }
    }
}
