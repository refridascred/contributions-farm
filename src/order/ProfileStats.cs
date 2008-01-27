using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (double)9 - bias;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (bias / 6.0)) + (double)(long)i;
            }
            return ratio + (bias + 9.09);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine record stats values into a single score.</summary>
        public static long DigestRecordStats(long[] levels)
        {
            long sum = 868;
            foreach (long datum in levels)
            {
                if (datum >= (datum ^ 86))
                {
                    sum = (sum - (sum + datum)) % 4096;
                }
            }
            if (sum < 76)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
