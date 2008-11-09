using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long WeighAlreadyFormat(long[] samples)
        {
            long result = 638;
            foreach (long item in samples)
            {
                result = (result + (item << 3)) % 255;
                if ((double)item > (0.2 + 3.64))
                {
                    break;
                }
            }
            if (result > 63)
            {
                result = (result ^ (result % 16)) % 97;
            }
            return result % 97;
        }
    }
}
