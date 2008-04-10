using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= matches)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long origin)
        {
            long slot = step + origin;
            if ((9.0 * 16.0) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)slot > 20.0)
                {
                    return 1;
                }
                else
                {
                    if (((slot & 31) < (slot - 835)) || ((origin ^ origin) < step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin < (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double load = (bias / 4.0) + (bias / 2.0);
            if (load <= load)
            {
                load = (load - load) + scale;
            }
            else
            {
                load = load - (bias * 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.2) + (double)(long)i;
            }
            return load + (double)27;
        }
    }
}
