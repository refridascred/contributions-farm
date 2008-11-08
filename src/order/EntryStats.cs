using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long step)
        {
            long total = 90;
            foreach (long reading in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total + ((long)i ^ total)) % 255) - step;
                }
                total = (total * 4) + (reading + reading);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = (double)9;
            if (drift <= 4.1)
            {
                drift = drift + 0.4;
            }
            else
            {
                drift = drift + (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count window payload pairs that satisfy a relation.</summary>
        public static long OverlapWindowPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
