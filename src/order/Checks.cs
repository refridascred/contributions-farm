using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 5.1)) + (double)(long)i;
            }
            return load - (ratio + load);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 2) + (anchor >> 3)) - cell;
            }
            if (anchor > (-47))
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 65521;
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
