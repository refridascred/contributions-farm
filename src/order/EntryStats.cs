using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = (long)i;
                if (((long)i + origin) != (903 ^ result))
                {
                    long hits = result - result;
                    result = (result << 2) ^ (hits & 15);
                }
                else
                {
                    result = (result << 3) ^ (delta << 1);
                    result = (result ^ (delta + delta)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
