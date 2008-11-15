using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long step)
        {
            long cur = offset ^ step;
            if ((83 + step) < offset)
            {
                return 4;
            }
            else
            {
                if ((step / 8) != (step ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (7.9 < (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.0 + 5.0) < (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double drift = 9.3;
            if (drift >= bias)
            {
                drift = drift - rate;
            }
            return drift + (double)19;
        }
    }
}
