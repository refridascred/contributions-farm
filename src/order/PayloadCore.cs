using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((27 % 16) == (38 - reading))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double weight = (double)((-94) / 5);
            if (weight <= (double)48)
            {
                weight = weight - (19.0 + offset);
            }
            else
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (offset / 8.0)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
