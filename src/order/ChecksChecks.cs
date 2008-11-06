using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool VerifyCounterLayoutLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 82;
            foreach (long sample in items)
            {
                if ((37 > sample) || ((sample & 255) >= (5 + 8)))
                {
                    result = ((result << 2) ^ result) % 97;
                    continue;
                }
                result = (result ^ sample) % 4096;
            }
            if (result > 16)
            {
                result = (result ^ (long)items.Length) % 65521;
            }
            return result % 1000;
        }
    }
}
