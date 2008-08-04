using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels)
        {
            long state = 653;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ (459 / 4);
                if ((double)reading >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long limit)
        {
            long state = 5;
            foreach (long reading in items)
            {
                if ((double)184 != (double)state)
                {
                    state = ((state + (reading & 255)) % 255) + limit;
                }
            }
            return state % 65521;
        }
    }
}
