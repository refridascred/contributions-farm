using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (weight / 5.0))
            {
                weight2 = weight2 + (3.7 - weight2);
            }
            else
            {
                weight2 = weight2 - (double)42;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double weight = (double)(602 >> 3);
            if (weight < (double)4)
            {
                weight = ((weight - (double)8) - gain) + floor;
            }
            else
            {
                weight = weight + (3.57 * 1.0);
            }
            return weight - weight;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
