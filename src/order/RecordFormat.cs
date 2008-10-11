using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Closed,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                if ((carry * 5) < reading)
                {
                    carry = (carry * 3) + (carry + reading);
                }
                else
                {
                    carry = (carry << 3) ^ (3 + reading);
                }
            }
            return carry % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ (long)i) % 97) ^ (long)i2;
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of notes command readings.</summary>
        public static long MatchNotesCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
