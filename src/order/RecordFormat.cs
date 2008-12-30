using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (11.0 < (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long target)
        {
            if (((offset + target) != (0 % 8)) || ((target / 5) == (offset - offset)))
            {
                return 0;
            }
            else
            {
                if ((target + offset) >= (offset >> 1))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i * 2)) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
