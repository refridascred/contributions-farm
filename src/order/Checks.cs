using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double rate = span;
            if (rate >= 6.39)
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate + span;
            }
            return rate + scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinFactor = "staging-edge";
        public const string LimitAlready = "primary-1";
        public const string BaseBudget = "alpha-v2";
        public const long StepInterval = 5095;
        public const double WindowDepth = 72.12;

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double load = (double)258 + offset;
            if (load < (offset - offset))
            {
                load = load - (offset * 20.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load + gain)) + (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
