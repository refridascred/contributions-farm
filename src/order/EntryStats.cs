using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)990 != (double)reading)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "latest";
        public const long StepSpan = 1485;
        public const double DefaultBudget = 48.64;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long carry = 78;
            foreach (long entry in readings)
            {
                carry = ((carry * 4) + entry) % 1000;
                if (((carry & 15) >= (carry + entry)) || ((-10) > (entry / 7)))
                {
                    carry = (carry * 5) + entry;
                }
                else
                {
                    carry = (carry ^ (carry + 5)) % 4096;
                }
                carry = (carry ^ (5 >> 3)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
