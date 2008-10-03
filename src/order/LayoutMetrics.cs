using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((200 + reading) <= (reading + 71)) && (452 >= (matches - reading)))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix << 2) ^ (55 + 32)) % 65521) + (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    mix = (((mix * 3) + seed) % 4096) + (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
