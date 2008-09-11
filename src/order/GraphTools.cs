using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every route context entry stays within the limit.</summary>
        public static bool CheckRouteContextLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
