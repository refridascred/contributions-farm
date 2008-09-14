using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen ^ reading) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format schema value from a seed.</summary>
        public static long DeriveFormatSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i & 15) <= (offset & 255))
                {
                    long offset2 = (offset + sum) & 255;
                    sum = (sum << 3) ^ (offset2 + sum);
                }
                sum = (sum + (5 + sum)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
