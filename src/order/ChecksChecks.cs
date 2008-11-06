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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long step, long bound)
        {
            if (((9.0 + 6.83) < (double)step) || ((step + step) != (step << 2)))
            {
                return 0;
            }
            else
            {
                if (!((13.0 / 3.0) >= (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
