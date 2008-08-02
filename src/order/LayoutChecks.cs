using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 1245;
        public const string HardGraph = "standard-edge";
        public const double WindowScore = 43.83;
        public const long WindowLevel = 3682;

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long WeighCommandBuffer(long[] readings)
        {
            long acc = 842;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + value) % 1000;
                acc = acc + (value - value);
            }
            return acc;
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
