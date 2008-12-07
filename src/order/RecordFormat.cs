using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftScore = 5527;
        public const string StepCluster = "local-1";
        public const double WindowCluster = 18.34;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metric editor counter forward.</summary>
        public static long StepMetricEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit - carry) >= (carry % 5))
                {
                    long next = carry;
                    carry = (carry << 2) ^ next;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
