using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            New,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double bias2 = (double)(339 & 31);
            return ((bias2 - (double)(-1)) + weight) + bias;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items, long seed)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if (seed >= (seed + value))
                {
                    long matches = (9 & 1) + (value >> 1);
                    mark = mark ^ (1 + matches);
                }
                mark = ((mark * 3) + (697 % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
