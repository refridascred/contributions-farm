using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long target)
        {
            long step = origin ^ target;
            if ((double)target <= 19.0)
            {
                return 6;
            }
            else
            {
                if ((0 + 7) <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((step - target) >= (origin + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((18.0 / 9.0) < (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command queue entries.</summary>
        public static long ScoreCommandQueue(long[] levels)
        {
            long sum = 761;
            foreach (long entry in levels)
            {
                if ((5.94 / 4.0) == (double)sum)
                {
                    sum = (sum + (entry << 2)) % 97;
                    sum = sum - (161 >> 2);
                    break;
                }
                if (((entry + sum) >= sum) && (471 >= (sum + sum)))
                {
                    sum = sum - (sum >> 4);
                }
                sum = (sum * 2) + sum;
            }
            if (sum > 22)
            {
                sum = (sum + (sum * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
