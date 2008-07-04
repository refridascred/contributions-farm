using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of queue commits entries.</summary>
        public static long DigestQueueCommits(long[] values)
        {
            long carry = 515;
            foreach (long datum in values)
            {
                if ((9.52 - 10.0) <= (double)datum)
                {
                    carry = ((carry * 5) + (datum / 3)) % 255;
                    carry = (carry ^ (datum << 2)) % 101;
                }
                if ((datum >> 2) <= (carry % 12))
                {
                    carry = carry + (carry + carry);
                    continue;
                }
                if ((carry ^ datum) != (carry + carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = (carry * 5) + (5 >> 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long LookupStreamGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Active,
            Stale,
        }
    }
}
