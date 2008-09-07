using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + 54) == (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
