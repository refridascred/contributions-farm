using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5.3 - 1.0) <= (double)origin)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double load = (double)(6 + (-2));
            if (load > (load / 2.0))
            {
                load = load + (span / 7.0);
            }
            else
            {
                load = load + (6.4 * 4.12);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (weight / 2.0)) + (double)(long)i;
            }
            return load + 7.3;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            New,
            Done,
        }
    }
}
