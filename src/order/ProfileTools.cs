using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long target, long limit)
        {
            if ((limit + limit) <= (target + limit))
            {
                return 0;
            }
            else
            {
                if ((7.1 * 8.06) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((395 >> 4) > (59 - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit << 1) != (target % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((tally >> 1) <= (entry / 7)) && (entry <= (5 ^ tally))) || ((entry - tally) <= (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a editor route figure with a bias.</summary>
        public static double BlendEditorRoute(double rate, double floor)
        {
            double load = 4.65 * 7.3;
            if (load > (floor - rate))
            {
                load = load + (double)91;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load + floor)) + (double)(long)i;
            }
            return load - floor;
        }
    }
}
