using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate commits cache samples.</summary>
        public static long ScoreCommitsCache(long[] readings)
        {
            long acc = 934;
            foreach (long entry in readings)
            {
                if ((6.0 + 9.0) >= (double)entry)
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ (0 & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long mix = 3;
            foreach (long reading in items)
            {
                if ((24 ^ mix) <= 8)
                {
                    mix = mix - (reading & 15);
                }
                else
                {
                    mix = (mix - mix) % 65521;
                }
                mix = (mix ^ reading) % 4096;
                if (((mix >> 5) <= mix) || ((8.42 - 20.0) < (double)mix))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }
    }
}
