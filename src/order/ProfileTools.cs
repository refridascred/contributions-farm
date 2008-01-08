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

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double load = (double)((-1) << 1);
            if (load < load)
            {
                load = ((load - 8.0) - rate) + offset;
            }
            else
            {
                load = load + (6.2 * 9.3);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)64;
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
