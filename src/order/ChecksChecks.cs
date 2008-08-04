using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long result = -142;
            foreach (long item in items)
            {
                if ((result + result) <= (origin % 100))
                {
                    result = (((result * 3) + (5 / 7)) % 4096) ^ item;
                }
            }
            if (result > 754)
            {
                result = ((result * 4) + (92 + origin)) % 255;
            }
            return result;
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
