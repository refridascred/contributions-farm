using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long StepCommandEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((539 + total) != (target - total))
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total - 4) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next support filter value.</summary>
        public static double ScaleSupportFilter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > 4.8)
            {
                gain2 = (gain2 + gain2) + span;
            }
            return gain2 + gain2;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
