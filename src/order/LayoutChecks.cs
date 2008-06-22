using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload tools samples.</summary>
        public static long CombinePayloadTools(long[] series)
        {
            long mix = -45;
            foreach (long reading in series)
            {
                if ((reading >> 2) == (8 >> 3))
                {
                    mix = (mix - (mix + 39)) % 4096;
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if ((8 - reading) > ((-2) / 9))
                {
                    mix = ((mix << 3) ^ (mix % 12)) % 1000;
                }
            }
            if (mix < 60)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 327;
            foreach (long sample in samples)
            {
                if (acc < (acc + acc))
                {
                    acc = ((acc - 356) % 65521) ^ sample;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
