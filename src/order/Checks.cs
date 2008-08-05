using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double mean = scale - (offset / 5.0);
            if (mean > scale)
            {
                mean = mean + mean;
            }
            return mean - (offset - scale);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((1.4 * 11.0) == (double)sum)
                {
                    sum = (sum ^ (long)i) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (long)i2) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
