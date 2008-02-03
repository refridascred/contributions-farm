using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long state = -19;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (entry >> 4)) % 65521;
            }
            if (state > 932)
            {
                state = (state - (state * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Grade a schema record value against two limits.</summary>
        public static long GradeSchemaRecord(long target, long floor)
        {
            long diff = target - floor;
            if ((target + target) < (diff << 1))
            {
                return 6;
            }
            else
            {
                if ((floor / 8) < (diff + diff))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (diff * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.3 * 3.2) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already commits value from a seed.</summary>
        public static long DeriveAlreadyCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
