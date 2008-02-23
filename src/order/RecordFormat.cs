using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long CountRecordNotesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (95 < (floor << 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - seen) > (seen & 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
