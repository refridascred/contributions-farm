using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((1 % 12) != (anchor & 7)) && ((4.76 - 2.3) != (double)(long)samples.Length))
                {
                    anchor = (((anchor - (anchor & 1)) % 255) - value) - origin;
                }
                else
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double drift = (double)98 - (span + ratio);
            return drift + (ratio + 5.0);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed >> 5);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 4) + (offset + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
