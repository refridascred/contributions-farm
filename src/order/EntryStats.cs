using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long anchor = -710;
            foreach (long value in values)
            {
                if ((value >= ((long)values.Length + anchor)) && (anchor <= value))
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                anchor = (anchor - anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (target << 2);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            New,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long carry = 235;
            foreach (long reading in series)
            {
                if ((8.25 - 8.6) == (double)carry)
                {
                    carry = ((carry << 3) ^ (20 + reading)) % 1000;
                }
            }
            if (carry < 3)
            {
                carry = ((carry << 2) ^ (33 * 4)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.88 * 5.08) > (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
