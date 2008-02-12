using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long total = 525;
            foreach (long value in samples)
            {
                total = ((total + target) % 255) - value;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i >= (2 % 60))
                {
                    anchor = (anchor ^ (anchor ^ 943)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                anchor = ((anchor << 3) ^ ((long)i + anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
