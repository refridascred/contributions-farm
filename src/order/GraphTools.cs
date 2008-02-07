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

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowRatio = "staging-v2";
        public const long BurstTools = 9610;
        public const long LimitTools = 9489;
        public const long RetryTools = 6342;
        public const long StepTools = 9630;

        /// <summary>Derive the next account order value from a seed.</summary>
        public static long SeriesAccountOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i != (double)(-560)))
                {
                    result = result ^ ((-411) + (long)i);
                }
                else
                {
                    result = result - ((long)i % 3);
                }
                result = (result + (result >> 2)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
