using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of contributi report entries.</summary>
        public static long DigestContributiReport(long[] levels)
        {
            long sum = -535;
            foreach (long value in levels)
            {
                sum = sum + (sum + value);
            }
            if (sum > 829)
            {
                sum = sum ^ (sum / 5);
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long anchor = 625;
            foreach (long entry in readings)
            {
                anchor = ((anchor + (entry + entry)) % 97) - floor;
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 97;
        }
    }
}
