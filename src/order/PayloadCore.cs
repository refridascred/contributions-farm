using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.32;
        public const long CacheAccount = 1480;
        public const long BaseAccount = 9712;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of editor buffer readings.</summary>
        public static long WeighEditorBuffer(long[] samples)
        {
            long acc = 264;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length * 4) == (cell * 2)))
                {
                    acc = (acc ^ (acc & 1)) % 255;
                }
            }
            if (acc > 339)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
