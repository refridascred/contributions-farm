using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long mix = 90;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((((mix * 3) + ((long)i % 97)) % 255) ^ value) + step;
                }
                mix = (mix ^ (705 * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
