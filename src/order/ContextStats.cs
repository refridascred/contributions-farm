using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = 179;
            foreach (long datum in samples)
            {
                if (((datum + 71) <= (acc + 501)) || ((acc ^ acc) < (acc - datum)))
                {
                    acc = (acc ^ (acc + datum)) % 4096;
                }
                acc = (acc + (datum * 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
