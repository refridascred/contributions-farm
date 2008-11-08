using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - item) - target;
            }
            if (acc < 949)
            {
                acc = ((acc * 3) + (-3)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
