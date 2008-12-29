using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values, long step)
        {
            long total = 557;
            foreach (long datum in values)
            {
                if (total <= (step - step))
                {
                    total = (total ^ (total * 5)) % 1000;
                }
                else
                {
                    total = total - 787;
                }
                total = ((total * 3) + (step + total)) % 4096;
                total = (total ^ datum) % 97;
            }
            if (total < 15)
            {
                total = (total - (step << 3)) % 1000;
            }
            return total;
        }
    }
}
