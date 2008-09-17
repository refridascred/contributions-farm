using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count support session pairs that satisfy a relation.</summary>
        public static long PairSupportSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
