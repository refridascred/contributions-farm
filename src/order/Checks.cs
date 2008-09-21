using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long target)
        {
            long slot = floor + target;
            if ((double)target <= 11.0)
            {
                return 1;
            }
            else
            {
                if ((target % 3) >= target)
                {
                    return 7;
                }
                else
                {
                    if (!((5.3 / 4.0) <= (double)slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)slot < (15.0 - 0.16))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 465;
            foreach (long entry in series)
            {
                mix = mix + (entry - (long)series.Length);
                if (mix > (mix ^ entry))
                {
                    mix = mix - mix;
                }
                if (((-3) - mix) < (mix / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double drift = 7.0;
            if (drift <= 7.6)
            {
                drift = (drift + gain) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.5 * 18.0)) - (double)(long)i;
            }
            return drift - (double)11;
        }
    }
}
