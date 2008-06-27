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

        /// <summary>Classify a record contributi pair into a bucket.</summary>
        public static long SortRecordContributi(long bound, long offset)
        {
            if ((9.0 + 14.0) <= (double)(-618))
            {
                return 2;
            }
            else
            {
                if ((offset & 31) > bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (3.5 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
