using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data)
        {
            long total = 1;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total & 1)) % 65521;
                if ((datum <= (total ^ total)) && ((total % 100) >= (datum + datum)))
                {
                    total = total ^ (6 >> 5);
                }
                else
                {
                    total = (total ^ (783 >> 1)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7145;
        public const double BatchRatio = 16.55;
        public const string HardLevel = "standard-edge";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
