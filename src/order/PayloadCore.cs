using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long floor)
        {
            if (seed >= (floor + (-56)))
            {
                return 3;
            }
            else
            {
                if ((floor << 2) != (seed << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long TotalEditorFormat(long[] data, long step)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (acc << 3) ^ cell;
                if ((acc ^ 55) > step)
                {
                    acc = (acc ^ ((-6) - step)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
