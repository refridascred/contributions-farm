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

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public double Score { get; set; }
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((57 & 127) > value)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
