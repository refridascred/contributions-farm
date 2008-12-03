using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a checks window counter forward.</summary>
        public static long DeriveChecksWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((sum - (-5)) >= (floor + floor))
                {
                    sum = ((sum * 3) + (sum - (long)i)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Validate payload graph readings against a bound.</summary>
        public static bool VerifyPayloadGraphRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((offset << 1) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (double)359)
                {
                    return 4;
                }
                else
                {
                    if (((floor + offset) < (offset & 7)) || ((double)offset > (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
