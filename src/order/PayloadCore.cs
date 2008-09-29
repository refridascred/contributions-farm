using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value & 127) <= 9)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool VerifyFilterSchemaRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
