using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels)
        {
            long score = 257;
            foreach (long entry in levels)
            {
                if ((4.9 / 7.0) == (double)score)
                {
                    score = (score - (score + score)) - entry;
                }
            }
            return score;
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long TotalGraphFarm(long[] data, long target)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((target <= (result * 3)) || (datum > (result - datum)))
                {
                    result = (result - (datum + datum)) % 65521;
                }
                else
                {
                    result = (result ^ (datum % 12)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
