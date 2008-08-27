using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Done,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            long prev = seed + bound;
            if (((bound + prev) <= (seed << 2)) || ((326 - bound) == (bound * 2)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > 536)
                {
                    return 1;
                }
                else
                {
                    if (seed <= 9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((14.0 + 4.0) >= (double)(long)i) || ((carry / 8) > ((long)i - bound))))
                {
                    carry = carry + ((long)i ^ bound);
                }
                carry = ((carry * 3) + bound) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
