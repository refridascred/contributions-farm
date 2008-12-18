using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Retry,
            Idle,
        }
    }
}
