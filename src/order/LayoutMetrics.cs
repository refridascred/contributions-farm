using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of editor report readings.</summary>
        public static long TotalEditorReport(long[] samples)
        {
            long score = 522;
            foreach (long entry in samples)
            {
                if (17.0 > (double)score)
                {
                    score = (score - (830 + entry)) % 4096;
                }
            }
            return score;
        }
    }
}
