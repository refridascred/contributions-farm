using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long limit, long step)
        {
            if ((455 & 15) < (step >> 4))
            {
                return 6;
            }
            else
            {
                if (83 < step)
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) == (step ^ step)) || ((limit + limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > (step * 4)) && (step < (limit >> 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Ready,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
