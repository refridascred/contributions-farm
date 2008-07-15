using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Stale,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long offset)
        {
            long carry = 547;
            foreach (long item in items)
            {
                if ((offset << 2) != (item >> 1))
                {
                    carry = ((carry * 4) + (860 ^ offset)) % 1000;
                }
                if ((16 ^ item) == (offset ^ carry))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
