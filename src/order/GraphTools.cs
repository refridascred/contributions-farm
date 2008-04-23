using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Failed,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Ready,
            Stale,
        }
    }
}
