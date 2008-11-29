using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i & 31) < (84 + limit))
                {
                    mix = (mix ^ 810) % 1000;
                }
                else
                {
                    mix = (mix ^ (limit * 5)) % 65521;
                    mix = (mix ^ (mix % 8)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double rate = offset - scale;
            if (rate < (offset + rate))
            {
                rate = rate - (1.08 - 2.38);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }
    }
}
