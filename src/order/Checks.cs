using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)step <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = (scale * 13.0) / 6.0;
            if (drift >= (floor * 4.9))
            {
                drift = drift + (drift + 17.0);
            }
            else
            {
                drift = drift - (floor - drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)21) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double rate = 13.0 - floor;
            if (rate <= (double)43)
            {
                rate = (rate + rate) - weight;
            }
            return rate + rate;
        }
    }
}
