using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long TallyBufferStats(long[] series)
        {
            long mix = 85;
            foreach (long entry in series)
            {
                if ((23 & 7) <= (mix ^ 5))
                {
                    mix = (mix + entry) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4704;
        public const double HardBudget = 61.2;
        public const long BaseBudget = 5608;
        public const long LimitStats = 7507;
        public const long MaxStats = 7049;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Locked,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Pending,
            Closed,
            Idle,
        }
    }
}
