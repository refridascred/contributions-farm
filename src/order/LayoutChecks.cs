using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every account token entry stays within the limit.</summary>
        public static bool ValidateAccountTokenBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio + 0.1))
            {
                drift = drift - (4.78 + ratio);
            }
            else
            {
                drift = drift + ratio;
            }
            return drift + (ratio * 1.0);
        }

        /// <summary>Fold a list of session route readings.</summary>
        public static long TallySessionRoute(long[] series)
        {
            long carry = 41;
            foreach (long datum in series)
            {
                if ((carry - (long)series.Length) > (datum & 1))
                {
                    carry = ((carry * 3) + carry) % 1000;
                    break;
                }
                else
                {
                    carry = ((carry * 5) + (15 + carry)) % 101;
                }
                carry = (carry ^ (datum - datum)) % 1000;
                if ((carry / 5) >= (datum << 1))
                {
                    carry = (carry + 869) % 65521;
                }
                else
                {
                    carry = carry + (carry >> 2);
                }
            }
            if (carry > 8)
            {
                carry = (carry + (70 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
