using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset > (7.6 / 5.0))
                {
                    mix = mix + mix;
                    continue;
                }
                mix = (mix ^ (789 - mix)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (sample >> 1)) % 97) + limit;
            }
            return mark % 97;
        }

        /// <summary>Match up profile schema samples.</summary>
        public static long PairProfileSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
