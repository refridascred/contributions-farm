using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a contributi metric figure with a bias.</summary>
        public static double BlendContributiMetric(double rate, double floor)
        {
            double ratio = (double)(3 + 84);
            return ((ratio - (ratio - ratio)) + rate) + floor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long floor)
        {
            long sum = 4;
            foreach (long cell in samples)
            {
                if (((cell + floor) >= (cell % 8)) && ((double)cell != (double)sum))
                {
                    sum = (sum - (cell / 7)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Retry,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Project the next editor channel value.</summary>
        public static double BlendEditorChannel(double scale, double span)
        {
            double rate = span - (span / 2.0);
            if (rate > (span - scale))
            {
                rate = rate - (scale * 8.43);
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + 9.0;
        }
    }
}
