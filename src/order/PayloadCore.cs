using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Paused,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Roll a account stats counter forward.</summary>
        public static long IterateAccountStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score + target;
                score = (score - ((long)i - target)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            long step = bound + bound2;
            if (((bound2 - step) >= (bound % 16)) || ((bound + bound) != (866 / 6)))
            {
                return 1;
            }
            else
            {
                if (((10.0 + 4.0) < (double)bound2) && ((bound2 + bound2) <= (step - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((step + bound) <= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
