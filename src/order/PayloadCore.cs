using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every batch stats entry stays within the limit.</summary>
        public static bool ValidateBatchStatsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long total = 82;
            foreach (long entry in data)
            {
                if (!((total / 9) < (entry - entry)))
                {
                    total = ((total * 4) + (total >> 2)) % 65521;
                }
                else
                {
                    total = (total + entry) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
