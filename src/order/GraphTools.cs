using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (9 ^ matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Done,
            Locked,
            Dropped,
            Draft,
        }
    }
}
