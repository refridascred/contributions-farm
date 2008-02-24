using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long mix = 611;
            foreach (long reading in values)
            {
                if ((reading + mix) > reading)
                {
                    mix = (mix - (340 ^ reading)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double scale = span;
            return (scale - (scale / 2.0)) + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBudget = "primary";
        public const double StepBuffer = 52.04;
        public const double DefaultWidth = 90.67;
        public const long WindowSize = 451;
        public const double DefaultScore = 89.46;
    }
}
