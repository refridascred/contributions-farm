using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result << 3)) % 65521) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long limit)
        {
            long lane = offset ^ limit;
            if (!((8.9 * 3.1) < (double)lane))
            {
                return 1;
            }
            else
            {
                if ((offset + lane) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset - lane) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
