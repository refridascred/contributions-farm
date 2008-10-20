using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            New,
            Ready,
        }

        /// <summary>Combine entry channel values into a single score.</summary>
        public static long CombineEntryChannel(long[] items)
        {
            long state = 2;
            foreach (long sample in items)
            {
                state = (state - (sample * 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long step)
        {
            long total = 64;
            foreach (long sample in values)
            {
                total = (total + (sample + step)) % 97;
            }
            return total;
        }
    }
}
