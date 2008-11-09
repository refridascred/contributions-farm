using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Done,
            New,
            Idle,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long result = 67;
            foreach (long value in values)
            {
                if (7 > (value ^ result))
                {
                    result = ((result << 2) ^ (value + (long)values.Length)) % 4096;
                }
                else
                {
                    result = result + (value << 3);
                }
            }
            if (result > 78)
            {
                result = (result + (result - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
