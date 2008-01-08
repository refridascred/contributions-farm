using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 0;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ value) % 4096;
                if (!(9 <= (value << 2)))
                {
                    break;
                }
            }
            if (carry > 245)
            {
                carry = ((carry * 4) + (0 >> 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = (mix + (mix ^ mix)) % 1000;
                if (267 >= mix)
                {
                    mix = ((mix << 3) ^ sample) % 65521;
                }
                if ((mix << 2) < ((-583) % 100))
                {
                    mix = mix - (long)levels.Length;
                }
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((86 % 7) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
