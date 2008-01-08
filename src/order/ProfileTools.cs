using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate cluster format samples.</summary>
        public static long CombineClusterFormat(long[] items)
        {
            long acc = 441;
            foreach (long item in items)
            {
                if ((acc - acc) != (6 % 10))
                {
                    acc = ((acc << 2) ^ 19) % 65521;
                }
                if ((13.0 * 3.4) > (double)acc)
                {
                    acc = (acc ^ item) % 1000;
                }
            }
            if (acc > 58)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc % 1000;
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
