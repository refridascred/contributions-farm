using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight - (offset - 15.0);
            if (mean >= (weight * 1.6))
            {
                mean = mean + (double)763;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (offset - mean)) + (double)(long)i;
            }
            return mean - (double)565;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long limit)
        {
            long prev = bound + limit;
            if ((1.83 * 12.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (((8 ^ prev) != (22 - limit)) || (68 < (prev - 966)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Queued,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data)
        {
            long anchor = 159;
            foreach (long entry in data)
            {
                if ((entry + anchor) < (entry - entry))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor + anchor);
                }
            }
            if (anchor < 90)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 101;
            }
            return anchor;
        }
    }
}
