using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 2) ^ (origin ^ (long)i)) ^ (long)i2;
                    mark = mark ^ (mark >> 5);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long floor)
        {
            long mix = 265;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix ^ (floor % 24)) % 1000) - (long)i) - reading;
                }
                mix = mix + ((-52) / 5);
            }
            if (mix < 31)
            {
                mix = mix ^ floor;
            }
            return mix % 65521;
        }
    }
}
