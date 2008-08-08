using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = (total - (sample >> 2)) % 4096;
                if ((total + sample) == (sample - total))
                {
                    total = (total * 3) + (sample >> 4);
                }
            }
            if (total > 2)
            {
                total = ((total * 3) + (total - 97)) % 1000;
            }
            return total % 65521;
        }
    }
}
