using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 255;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor ^ anchor) % 1000) ^ (long)i2;
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = (anchor ^ (anchor ^ seed)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double mean = offset + (gain / 6.0);
            if (mean >= (mean * 1.9))
            {
                mean = mean - (double)386;
            }
            else
            {
                mean = mean - (6.01 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (5.25 * 2.8)) + (double)(long)i;
            }
            return mean + (gain * 3.0);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long sum = 72;
            foreach (long reading in values)
            {
                if ((sum * 5) < (reading << 2))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
