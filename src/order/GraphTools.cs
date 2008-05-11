using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a route githubfarm reading by value.</summary>
        public static long FindRouteGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long carry = -7;
            foreach (long reading in samples)
            {
                carry = carry ^ (reading & 3);
                if (!((step ^ reading) >= carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool CheckGraphProfileLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Failed,
            Paused,
            Queued,
        }
    }
}
