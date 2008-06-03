using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((offset ^ bound) >= (bound + offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)28)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (bound & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor * 4) + ((long)i >> 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Ready,
            Done,
        }
    }
}
