using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support batch samples.</summary>
        public static long WeighSupportBatch(long[] readings)
        {
            long total = 739;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                total = (total ^ (datum + datum)) % 4096;
                total = (total + (datum ^ 13)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long FindToolsEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6089;
        public const long HardInterval = 9229;
        public const string BaseCluster = "primary-1";
        public const long WindowDepth = 4617;
        public const long HardCluster = 6872;

        /// <summary>Locate a format token reading by value.</summary>
        public static long LocateFormatTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Owner { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
