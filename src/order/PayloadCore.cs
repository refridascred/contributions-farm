using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((8 + seed) > (origin / 6))
            {
                return 6;
            }
            else
            {
                if ((14 * 5) == (origin - cur))
                {
                    return 1;
                }
                else
                {
                    if (3.44 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (reading + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
