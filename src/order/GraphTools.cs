using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long floor)
        {
            long result = 810;
            foreach (long entry in samples)
            {
                if ((double)entry >= (2.0 / 9.0))
                {
                    result = ((result * 3) + (long)samples.Length) + floor;
                }
                else
                {
                    result = (result << 2) ^ (17 & 31);
                }
            }
            return result;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long MinBuffer = 7254;
        public const long MaxSize = 6057;
        public const long SoftScore = 3606;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long target2)
        {
            long edge = target - target2;
            if ((target2 >= 274) || ((target2 << 1) <= (edge >> 3)))
            {
                return 4;
            }
            else
            {
                if (target < (target & 3))
                {
                    return 0;
                }
                else
                {
                    if (!((target + edge) >= (edge / 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
