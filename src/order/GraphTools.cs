using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.4 + 3.5) != (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double load = 17.0;
            if (load >= (rate + load))
            {
                load = load + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (span * 18.0)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Failed,
            Active,
        }
    }
}
