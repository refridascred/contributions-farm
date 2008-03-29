using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count profile channel pairs that satisfy a relation.</summary>
        public static long CompareProfileChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long floor)
        {
            if (4.9 >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((target >> 1) > floor)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
