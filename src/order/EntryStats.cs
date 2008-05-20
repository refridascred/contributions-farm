using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long DefaultProfile = 6318;
        public const long BatchBudget = 6801;
        public const long BatchSpan = 9785;

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double BlendCounterSupport(double ratio, double offset)
        {
            double weight = ratio;
            return (weight + (double)0) + offset;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 737;
            foreach (long value in readings)
            {
                if (((value & 1) == (mix + (long)readings.Length)) || ((mix + value) >= mix))
                {
                    mix = ((mix * 2) + (mix / 8)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
