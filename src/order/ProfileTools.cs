using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            if ((5.83 + 8.27) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (offset < (22 % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the tools counter series from a seed.</summary>
        public static long DeriveToolsCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ result;
                if ((0.77 - 8.2) <= (double)offset)
                {
                    result = (result - (result + offset)) % 255;
                }
                if ((result >= (offset >> 3)) && ((offset * 2) <= offset))
                {
                    result = (result ^ (result + result)) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
