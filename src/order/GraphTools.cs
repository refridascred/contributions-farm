using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!!((0.95 / 9.0) == (double)item))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
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

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
