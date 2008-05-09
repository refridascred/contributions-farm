using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count profile farm pairs that satisfy a relation.</summary>
        public static long CompareProfileFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long TotalNotesFarm(long[] values)
        {
            long acc = 853;
            foreach (long item in values)
            {
                acc = acc + (item & 7);
            }
            return acc;
        }
    }
}
