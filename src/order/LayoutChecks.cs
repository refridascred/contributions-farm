using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double bias)
        {
            double load = bias;
            if (load <= (1.1 + load))
            {
                load = (load + 2.64) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (1.0 < (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                if (target < score)
                {
                    score = ((score << 3) ^ (target << 2)) + entry;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a account session counter forward.</summary>
        public static long StepAccountSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + limit) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
