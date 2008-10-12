using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (6.1 / 4.0))
                {
                    hits = ((hits + 2) ^ datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long floor)
        {
            if (((double)floor >= (double)bound) || ((bound + floor) < (bound - floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - bound) > 13)
                {
                    return 4;
                }
                else
                {
                    if (floor > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.97 - 2.48) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
