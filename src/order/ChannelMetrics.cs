using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry graph readings against a rule.</summary>
        public static long TallyEntryGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((16.0 + 2.01) > (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long total = 952;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (total ^ datum)) % 97;
                total = (total ^ total) % 255;
                if (!((total + total) == (datum / 8)))
                {
                    total = total ^ 228;
                }
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (total & 127)) % 65521;
            }
            return total % 4096;
        }
    }
}
