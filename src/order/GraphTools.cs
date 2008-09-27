using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = result + bound;
                if ((double)result > (9.5 * 4.4))
                {
                    result = (result - (result + bound)) % 97;
                    result = (result - result) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two channel queue measurements.</summary>
        public static double ScaleChannelQueue(double gain, double floor)
        {
            double drift = (double)846 + (floor / 2.0);
            if (drift > 5.91)
            {
                drift = drift - (gain * 7.02);
            }
            return drift + (drift * 3.4);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
