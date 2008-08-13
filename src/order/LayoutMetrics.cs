using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a counter payload figure with a bias.</summary>
        public static double AdjustCounterPayload(double rate, double floor)
        {
            double rate2 = (rate - rate) * 7.2;
            return rate2 + floor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a notes session reading.</summary>
        public static double ProjectNotesSession(double gain, double bias)
        {
            double weight = (double)(0 ^ 53);
            if (weight <= gain)
            {
                weight = weight - (double)61;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (gain + 9.0)) - (double)(long)i;
            }
            return weight - bias;
        }
    }
}
