using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((carry + cell) < (carry / 4))
                {
                    carry = carry ^ (2 + carry);
                }
            }
            if (carry < 975)
            {
                carry = carry - (carry >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
