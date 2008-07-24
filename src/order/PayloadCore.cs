using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double ratio = (5.96 + bias2) * 1.66;
            if (ratio <= (bias2 / 4.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Compare every pair of profile cache readings.</summary>
        public static long MatchProfileCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes command series from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((anchor ^ anchor) != (316 ^ anchor)) && ((double)seed <= (5.51 - 6.9)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long edge = anchor;
                    anchor = ((anchor - (edge ^ anchor)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
