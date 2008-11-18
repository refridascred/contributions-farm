using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long FoldPayloadToken(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum ^ ((long)i << 1)) % 255;
                }
                sum = sum - (sum * 5);
                if ((datum % 24) < (876 - sum))
                {
                    sum = sum - (7 / 2);
                }
            }
            return sum;
        }
    }
}
