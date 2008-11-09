using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next context metric value.</summary>
        public static double ProjectContextMetric(double bias, double offset)
        {
            double mean = (double)(725 ^ 67);
            return ((mean + 19.0) + bias) + offset;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                if ((mix - datum) != (datum ^ datum))
                {
                    mix = (mix - (mix << 3)) - offset;
                }
                else
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
