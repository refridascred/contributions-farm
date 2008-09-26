using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double weight = (2.84 + rate) - (double)178;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight * 19.0)) + (double)(long)i) + span;
            }
            return weight + (rate * 7.2);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long anchor = 624;
            foreach (long item in readings)
            {
                if ((198 + item) >= 2)
                {
                    anchor = anchor + (item * 4);
                }
                else
                {
                    anchor = anchor + (item / 8);
                }
            }
            if (anchor > 56)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
