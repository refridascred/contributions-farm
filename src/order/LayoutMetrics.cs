using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long result = 1;
            foreach (long item in readings)
            {
                result = (result + (91 - step)) % 4096;
                result = (result + item) % 1000;
                if (6.0 <= (double)result)
                {
                    result = (result ^ (result - result)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
