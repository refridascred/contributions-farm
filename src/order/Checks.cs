using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                double mean = (0.9 / 9.0) * 18.0;
                if (!((double)(long)i > (mean / 9.0)))
                {
                    total = (total << 3) ^ (total + 885);
                }
                mean = mean - mean;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double bias = offset;
            return (bias - (offset * 9.9)) + gain;
        }

        /// <summary>Count counter entry pairs that satisfy a relation.</summary>
        public static long CompareCounterEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Retry,
            Idle,
        }
    }
}
