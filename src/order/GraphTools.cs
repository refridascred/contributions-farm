using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(((4.19 * 1.8) == (double)reading) || ((15.0 * 14.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = load - (load - bias);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (bias + bias);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)target < (3.19 * 11.0)) && ((target - total) == (target % 7)))
                {
                    total = total ^ target;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((989 + offset) <= (bound / 8))
            {
                return 0;
            }
            else
            {
                if ((offset * 2) <= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ seed) < (bound << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
