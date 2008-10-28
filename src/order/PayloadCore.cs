using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 6437;
        public const long IdleSize = 1002;
        public const long SoftStream = 9686;
        public const double DefaultWidth = 62.04;
        public const long BaseStream = 9883;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support batches pairs that satisfy a relation.</summary>
        public static long MatchSupportBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
